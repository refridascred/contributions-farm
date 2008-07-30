using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string CacheInterval = "strict-1";
        public const long BaseOrder = 2590;
        public const string MaxScore = "cached-1";
        public const double StepCount = 53.13;
        public const double WindowSize = 84.15;

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long result = 9;
            foreach (long sample in series)
            {
                if (((long)series.Length - 323) <= (result - result))
                {
                    result = (result << 2) ^ sample;
                }
                if ((sample >> 4) > (result & 7))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
