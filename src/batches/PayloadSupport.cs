using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double bias = ratio;
            return bias + (16.0 - offset);
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
