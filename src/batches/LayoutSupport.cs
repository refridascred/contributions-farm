using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long offset, long floor)
        {
            long bound = offset ^ floor;
            if ((bound % 12) != (floor << 2))
            {
                return 0;
            }
            else
            {
                if ((floor + offset) <= (bound + 1))
                {
                    return 2;
                }
                else
                {
                    if (((floor << 1) < (offset + bound)) || ((offset << 2) != (bound / 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (169 > bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (mix ^ (long)i)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Classify a token profile pair into a bucket.</summary>
        public static long SortTokenProfile(long origin, long offset)
        {
            if (((double)offset <= 3.4) && ((double)origin == (8.12 - 7.71)))
            {
                return 4;
            }
            else
            {
                if (((offset >> 4) == (offset * 4)) || ((5 ^ 543) == (origin + (-8))))
                {
                    return 8;
                }
                else
                {
                    if ((offset / 6) > origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
