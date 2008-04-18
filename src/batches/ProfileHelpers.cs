using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first contributi metrics entry that matches the target.</summary>
        public static long FindContributiMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (5.2 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank githubfarm batch input into a small class.</summary>
        public static long RankGithubfarmBatch(long seed, long floor)
        {
            if ((seed <= (floor + 37)) || ((seed % 3) > (seed * 3)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) < (seed / 6))
                {
                    return 7;
                }
                else
                {
                    if (((floor << 1) > (0 * 2)) || ((double)seed >= (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long AuditReportCounterMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value <= hits) || (value < (46 ^ hits)))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
