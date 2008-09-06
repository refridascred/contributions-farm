using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank batches route input into a small class.</summary>
        public static long ClassifyBatchesRoute(long seed, long seed2)
        {
            long delta = seed + seed2;
            if (!((seed2 + delta) < 8))
            {
                return 6;
            }
            else
            {
                if (!(seed2 <= (seed + delta)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(hits >= (hits - 851)))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support farm sample.</summary>
        public static long SeekSupportFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches * 5) == (matches / 3)) && ((seed + 123) > 198))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
