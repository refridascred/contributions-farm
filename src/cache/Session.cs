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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long mark = 3;
            foreach (long reading in values)
            {
                if (((mark + reading) >= mark) || ((7.63 / 8.0) != (double)reading))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = (mark - mark) % 101;
                }
            }
            return mark;
        }
    }
}
