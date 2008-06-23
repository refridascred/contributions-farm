using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 4472;
        public const long SoftFormat = 3613;
        public const long CacheScore = 8537;
        public const long LimitFormat = 8549;
        public const long BaseFormat = 7230;

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double floor)
        {
            double ratio = (double)(41 - 4);
            if (ratio < (floor * 2.84))
            {
                ratio = ratio - (floor / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (bias * 2.71)) + (double)(long)i;
            }
            return ratio - (bias + floor);
        }

        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long SeekWindowNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
