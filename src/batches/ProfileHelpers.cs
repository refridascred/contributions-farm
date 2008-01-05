using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchDepth = "stable-edge";
        public const long SoftDepth = 2462;
        public const long BurstSchema = 3566;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long bound)
        {
            long acc = 4;
            foreach (long value in levels)
            {
                if (6 > (value + acc))
                {
                    acc = acc + (acc + bound);
                }
                else
                {
                    acc = (acc * 5) + (value / 9);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (677 - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Rank entry graph input into a small class.</summary>
        public static long SortEntryGraph(long floor, long step)
        {
            if (!((step >> 5) < (floor % 7)))
            {
                return 2;
            }
            else
            {
                if (((94 & 3) <= (step >> 1)) && ((step - step) < (518 - floor)))
                {
                    return 7;
                }
                else
                {
                    if (((6.2 / 5.0) <= (double)floor) && ((9.78 - 1.0) >= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((15.0 - 7.48) >= (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long seed)
        {
            if (((bound >> 5) > bound) && ((bound + bound) == (88 - bound)))
            {
                return 7;
            }
            else
            {
                if ((bound << 3) > (bound + 23))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (1.7 * 1.55))
                    {
                        return 5;
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
