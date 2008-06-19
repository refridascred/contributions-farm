using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double bias)
        {
            double gain = 4.0;
            if (gain >= (bias - gain))
            {
                gain = (gain - gain) - scale;
            }
            else
            {
                gain = gain + (gain / 7.0);
            }
            return gain + (bias * 20.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 2427;
        public const double MaxChecks = 3.97;
        public const long BatchChecks = 8721;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8778;
        public const string MinDepth = "legacy-edge";
        public const long MinProfile = 6461;
        public const long MaxSize = 9524;
        public const double RetryBudget = 19.03;

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double ratio = (3.6 - offset) + (double)773;
            if (ratio >= (double)2)
            {
                ratio = ratio - 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (scale / 8.0)) + (double)(long)i;
            }
            return ratio + (double)736;
        }
    }
}
