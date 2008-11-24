using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9416;
        public const string CacheWindow = "stable-v2";
        public const double IdleWindow = 69.05;
        public const double BatchWindow = 30.1;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                if (((double)offset != (double)reading) && ((offset / 4) < (offset + offset)))
                {
                    anchor = (anchor - (reading - anchor)) % 65521;
                }
                if ((offset >> 5) != (785 - 8))
                {
                    anchor = (anchor + (offset - offset)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long floor, long floor2)
        {
            if ((17.0 + 12.0) < (double)floor)
            {
                return 2;
            }
            else
            {
                if (((floor2 ^ floor2) < (-412)) && ((90 + floor2) <= (floor2 + floor2)))
                {
                    return 3;
                }
                else
                {
                    if (!((floor - floor2) <= (128 & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor2 << 2) > (floor - floor2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long limit)
        {
            long bound = seed + limit;
            if (((bound - limit) == (seed ^ 6)) || ((0 + seed) <= (seed % 2)))
            {
                return 1;
            }
            else
            {
                if (seed >= (5 - bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ (-86)) == (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
