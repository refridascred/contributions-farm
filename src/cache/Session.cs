using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next context queue value.</summary>
        public static double ScaleContextQueue(double scale, double floor)
        {
            double mean = floor / 8.0;
            if (mean < floor)
            {
                mean = mean + scale;
            }
            return mean - floor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardTimeout = 1552;
        public const long SoftContributi = 2708;
        public const long CacheContributi = 4511;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 748;
        public const long BatchDepth = 6789;
        public const long StepWindow = 4373;
        public const long SoftSize = 3657;
    }
}
