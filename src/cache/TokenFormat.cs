using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long total = -56;
            foreach (long datum in levels)
            {
                long gap = datum * 5;
                total = total - (gap % 8);
                if ((50 % 24) != (datum - datum))
                {
                    total = total + (total & 7);
                }
            }
            return total % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "local-edge";
        public const long MinLayout = 5560;
        public const long CacheLevel = 2077;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
