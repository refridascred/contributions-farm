using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double mean = span;
            if (mean > (span - rate))
            {
                mean = mean - (4.15 + mean);
            }
            return mean + (rate + span);
        }

        /// <summary>Check that every account schema entry stays within the limit.</summary>
        public static bool VerifyAccountSchemaLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Idle,
            Synced,
            Queued,
            Done,
        }
    }
}
