using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 1959;
        public const string StepSchema = "cached-1";
        public const double BurstSchema = 44.38;

        /// <summary>Combine queue farm values into a single score.</summary>
        public static long TotalQueueFarm(long[] values)
        {
            long mark = 620;
            foreach (long value in values)
            {
                mark = (mark - ((-126) >> 5)) + value;
            }
            return mark % 97;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
