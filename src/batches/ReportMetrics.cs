using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels, long origin)
        {
            long mix = 26;
            foreach (long cell in levels)
            {
                mix = ((mix + (cell << 2)) % 1000) + origin;
                if ((9.42 >= (14.0 * 4.85)) || ((3.1 * 5.0) < (double)cell))
                {
                    mix = (mix * 3) + (mix + cell);
                }
            }
            return mix;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchTimeout = 1645;
        public const double MaxSpan = 82.68;
        public const long BaseStream = 2766;
        public const double CacheStream = 50.91;
    }
}
