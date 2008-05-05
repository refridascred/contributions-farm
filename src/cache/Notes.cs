using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 8175;
        public const long BurstNotes = 5111;
        public const long MaxInterval = 2202;
        public const string BurstDepth = "fallback-v2";

        /// <summary>Check that every context metric entry stays within the limit.</summary>
        public static bool GuardContextMetricLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchFactor = 4203;
        public const string DefaultBatch = "primary-edge";
        public const string RetryBudget = "alpha-1";
        public const long SoftInterval = 9711;

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 18.1;
        public const long StepFormat = 927;
        public const string HardRatio = "alpha-1";
        public const string BatchFormat = "alpha";
    }
}
