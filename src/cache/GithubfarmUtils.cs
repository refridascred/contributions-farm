using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftRatio = 1317;
        public const long BatchStats = 5864;
        public const double LimitInterval = 70.01;
        public const long CacheTimeout = 4863;
        public const long IdleStats = 1759;

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels)
        {
            long mark = -6;
            foreach (long sample in levels)
            {
                mark = (mark ^ (sample ^ mark)) % 1000;
            }
            if (mark < 8)
            {
                mark = (mark * 4) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Audit context graph readings against a rule.</summary>
        public static long MeasureContextGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((7.3 / 3.0) >= (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                long next = origin & 7;
                next = (next - sum) % 101;
                sum = (sum << 3) ^ (next - sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
