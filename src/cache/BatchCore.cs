using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long target)
        {
            long sum = 63;
            foreach (long item in items)
            {
                if ((target / 5) == (sum ^ sum))
                {
                    sum = ((sum << 3) ^ (target + sum)) % 65521;
                    break;
                }
                if (sum > (item & 31))
                {
                    sum = sum - (-50);
                }
            }
            return sum % 65521;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long step)
        {
            long slot = bound - step;
            if ((slot >= (step - slot)) && ((bound & 7) != (bound & 255)))
            {
                return 6;
            }
            else
            {
                if (!(step < (55 + 62)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (8.85 + 7.6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry githubfarm entries.</summary>
        public static long FoldEntryGithubfarm(long[] levels, long seed)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                state = (((state + (state - state)) % 1000) + datum) - seed;
            }
            return state;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long step, long limit)
        {
            if (((double)limit <= (6.65 + 3.8)) || ((double)step < 7.82))
            {
                return 7;
            }
            else
            {
                if ((step >> 1) < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (step > (-21))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3 + 182) >= (limit / 2)) || (limit <= 55))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
