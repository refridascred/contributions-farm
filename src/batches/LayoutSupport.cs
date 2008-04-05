using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Draft,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            if ((floor << 1) > (floor2 ^ floor))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) != (floor2 / 8))
                {
                    return 2;
                }
                else
                {
                    if (919 >= (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank order profile input into a small class.</summary>
        public static long ClassifyOrderProfile(long step, long floor)
        {
            long gap = step ^ floor;
            if ((gap >= ((-65) + gap)) && ((5 >> 2) <= (floor - gap)))
            {
                return 1;
            }
            else
            {
                if (floor >= step)
                {
                    return 8;
                }
                else
                {
                    if ((step >> 5) >= (gap + 91))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor == (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long origin)
        {
            if ((double)step == (4.79 + 3.25))
            {
                return 1;
            }
            else
            {
                if ((origin - origin) < (origin % 2))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 3) < (step + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin == (1.0 * 19.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + 22) < (966 - entry))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
