using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metric cache readings against a rule.</summary>
        public static long CountMetricCacheGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)floor < (double)matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double gain = offset;
            return (gain + gain) + bias;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Ready,
            Locked,
            Retry,
        }
    }
}
