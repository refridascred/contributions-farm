using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a context tools pair into a bucket.</summary>
        public static long ClassifyContextTools(long limit, long seed)
        {
            long prev = limit + seed;
            if (((limit - limit) > (seed & 1)) && ((limit & 1) < seed))
            {
                return 2;
            }
            else
            {
                if ((double)prev <= (9.16 - 13.0))
                {
                    return 4;
                }
                else
                {
                    if (prev <= (seed + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - seed) >= 26)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Draft,
            Dropped,
        }
    }
}
