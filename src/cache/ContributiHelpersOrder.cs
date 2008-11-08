using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank already cache input into a small class.</summary>
        public static long SortAlreadyCache(long origin, long limit)
        {
            if (!((double)origin != (18.0 - 4.53)))
            {
                return 2;
            }
            else
            {
                if ((78 * 4) < limit)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a profile support reading.</summary>
        public static double AdjustProfileSupport(double ratio, double span)
        {
            double ratio2 = (double)(10 & 31);
            if (ratio2 >= ratio)
            {
                ratio2 = (ratio2 + ratio) + span;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + (ratio * 8.0)) - (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long floor)
        {
            long offset = limit ^ floor;
            if (89 < (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((offset - floor) <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((limit & 3) > (floor + offset)) || (offset < 811))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit << 3) <= (limit % 64)) || (floor <= (offset * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
