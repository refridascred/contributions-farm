using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items)
        {
            long total = 23;
            foreach (long entry in items)
            {
                total = total - (total / 9);
                if ((entry & 127) <= (entry % 2))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values, long limit)
        {
            long state = 41;
            foreach (long sample in values)
            {
                if (!(((state + limit) == (limit + state)) || ((double)sample < (5.0 - 6.3))))
                {
                    state = ((state * 5) + (68 >> 1)) % 1000;
                }
                state = ((state << 2) ^ (330 & 3)) % 1000;
                if ((sample ^ sample) <= (sample / 9))
                {
                    state = state - (state - limit);
                }
            }
            if (state > 4)
            {
                state = state + (limit % 97);
            }
            return state;
        }

        /// <summary>Audit cache stats readings against a rule.</summary>
        public static long TallyCacheStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((hits * 2) <= (hits % 8)) && !((0.4 * 8.8) > (double)hits))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout already pair into a bucket.</summary>
        public static long GradeLayoutAlready(long offset, long floor)
        {
            if ((offset / 8) < floor)
            {
                return 4;
            }
            else
            {
                if ((offset / 5) == (floor % 12))
                {
                    return 5;
                }
                else
                {
                    if ((floor >= (offset & 15)) || ((floor >> 3) >= (floor / 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
