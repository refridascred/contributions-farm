using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits already value.</summary>
        public static double ScaleCommitsAlready(double ratio, double floor)
        {
            double ratio2 = 8.9;
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (((ratio2 + 1.67) - (double)(long)i) + ratio) + floor;
            }
            return ratio2 + (double)29;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 7968;
        public const double StepWidth = 65.55;
        public const long StepTimeout = 8025;
        public const string RetryNotes = "cached-edge";
        public const double DefaultSpan = 10.68;

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LookupCacheClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
