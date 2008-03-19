using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-22) & 63) > sample)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item <= (item * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 4895;
        public const double DefaultToken = 47.6;
        public const string DefaultRatio = "fallback";
    }
}
