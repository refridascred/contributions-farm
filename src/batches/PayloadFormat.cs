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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally > (long)values.Length)
                {
                    tally = ((tally + 1) + entry) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate - (bias * 1.0);
        }
    }
}
