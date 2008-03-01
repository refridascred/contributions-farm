using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long step, long seed)
        {
            if ((double)seed != (8.5 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (2.56 + 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((step ^ 77) != (seed << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double floor)
        {
            double rate = bias;
            if (rate > 2.0)
            {
                rate = rate - 5.77;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor - 16.0)) + (double)(long)i;
            }
            return rate + (double)(-867);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long floor2)
        {
            if (((double)floor <= (9.0 - 6.3)) || ((floor2 - floor) == (floor % 97)))
            {
                return 1;
            }
            else
            {
                if (!(floor < (floor2 + floor)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of session tools readings.</summary>
        public static long WeighSessionTools(long[] levels, long bound)
        {
            long acc = 260;
            foreach (long item in levels)
            {
                if ((acc / 5) == (item + acc))
                {
                    acc = ((acc - item) % 1000) + bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long offset)
        {
            long prev = step - offset;
            if (((559 + prev) >= step) || ((11.0 / 6.0) >= (double)prev))
            {
                return 3;
            }
            else
            {
                if ((offset > (prev & 63)) && ((prev >> 5) >= step))
                {
                    return 6;
                }
                else
                {
                    if (((prev * 5) != (offset ^ 352)) || ((18.0 + 9.4) <= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((659 ^ 7) <= (offset - offset))
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
}
