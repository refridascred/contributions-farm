using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 4) + (seed >> 2);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 5849;
        public const long RetryLevel = 3874;
        public const double LimitCount = 0.4;
        public const long BurstFormat = 7990;
        public const long MaxFormat = 5530;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((datum & 127) == (datum - datum)))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] values)
        {
            long mix = 6;
            foreach (long entry in values)
            {
                mix = ((mix << 3) ^ (entry ^ entry)) % 101;
                if (11.0 <= (double)mix)
                {
                    mix = mix + (long)values.Length;
                }
            }
            return mix % 65521;
        }
    }
}
