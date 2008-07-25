using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((7.56 + 16.0) != (double)floor)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (floor ^ floor)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total ^ (floor * 2)) % 97) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryLevel = 1155;
        public const long DefaultScore = 7655;
        public const long BurstCommand = 2736;
        public const string BurstLevel = "fallback-edge";
        public const long CacheCommand = 5469;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long limit, long offset)
        {
            if (offset >= limit)
            {
                return 5;
            }
            else
            {
                if ((offset << 2) <= (0 & 31))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset <= (0.7 * 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
