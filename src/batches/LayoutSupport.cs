using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long step, long seed)
        {
            long lane = step + seed;
            if (!(((-1) + seed) > step))
            {
                return 1;
            }
            else
            {
                if (seed >= (lane >> 5))
                {
                    return 4;
                }
                else
                {
                    if (!(lane >= (seed + seed)))
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

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i - floor) >= (mark / 8))
                {
                    mark = (mark - floor) % 255;
                }
                else
                {
                    mark = (mark + (floor + (long)i)) % 65521;
                }
                mark = (mark - (mark % 100)) % 65521;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
