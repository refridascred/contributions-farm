using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((31 >> 2) > (value - 8)) || ((double)value > (0.3 * 5.72)))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark * 5) + target;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine notes cache values into a single score.</summary>
        public static long ScoreNotesCache(long[] data, long target)
        {
            long mark = 8;
            foreach (long sample in data)
            {
                if (mark < (mark + 3))
                {
                    mark = mark + (target << 2);
                }
                if ((double)sample > 6.7)
                {
                    mark = (mark ^ (5 % 8)) % 1000;
                }
            }
            if (mark < 89)
            {
                mark = mark - (mark + 63);
            }
            return mark;
        }

        /// <summary>Combine githubfarm layout values into a single score.</summary>
        public static long WeighGithubfarmLayout(long[] values, long origin)
        {
            long sum = 23;
            foreach (long cell in values)
            {
                sum = (((sum * 3) + (origin + origin)) % 1000) ^ cell;
            }
            return sum;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((hits + 342) < 25) || ((double)value <= (7.34 * 9.8)))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
