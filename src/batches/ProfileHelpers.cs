using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long limit, long floor)
        {
            if (limit >= floor)
            {
                return 3;
            }
            else
            {
                if (!((limit - floor) <= (limit + limit)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long target)
        {
            long slot = bound + target;
            if (target > (bound & 127))
            {
                return 4;
            }
            else
            {
                if (!((double)bound >= (6.62 * 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (target <= (bound - slot))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target << 2) > (target & 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = state - ((long)i2 * 3);
                }
                if ((state - seed) <= (long)i)
                {
                    state = (state - (seed << 2)) % 97;
                }
                if (((seed * 3) != (seed + state)) || ((0.2 * 5.7) > (double)state))
                {
                    state = ((state << 3) ^ (seed * 4)) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long FindCommitsSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading >= (tally * 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
