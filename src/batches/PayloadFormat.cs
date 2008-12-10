using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every channel batches entry stays within the limit.</summary>
        public static bool CheckChannelBatchesRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a contributi batches reading.</summary>
        public static double SmoothContributiBatches(double gain, double span)
        {
            double drift = gain - (span + span);
            if (drift >= (gain + drift))
            {
                drift = drift - (span / 6.0);
            }
            else
            {
                drift = drift - (4.4 / 9.0);
            }
            return drift + span;
        }
    }
}
