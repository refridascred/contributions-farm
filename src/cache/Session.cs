using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long seed)
        {
            if (bound < seed)
            {
                return 4;
            }
            else
            {
                if ((553 - bound) > (67 + bound))
                {
                    return 2;
                }
                else
                {
                    if ((4 - seed) == ((-566) % 7))
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

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] series, long seed)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                if ((entry & 127) == (mix << 1))
                {
                    mix = (mix + (entry << 2)) % 65521;
                }
                else
                {
                    mix = (mix + (entry - seed)) % 255;
                }
                if (((double)mix >= (3.0 - 12.0)) && ((7 + mix) >= (614 + entry)))
                {
                    mix = mix + entry;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + (4 & 15)) % 97) + entry;
            }
            return score;
        }
    }
}
