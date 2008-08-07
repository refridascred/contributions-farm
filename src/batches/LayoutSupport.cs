using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long bound, long offset)
        {
            long step = bound + offset;
            if ((bound + bound) > (step + 21))
            {
                return 8;
            }
            else
            {
                if ((1 >> 1) <= (offset & 15))
                {
                    return 0;
                }
                else
                {
                    if (((offset * 2) < step) && ((417 >> 5) != (step - 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a commits stream reading.</summary>
        public static double ProjectCommitsStream(double gain, double bias)
        {
            double scale = (bias - gain) * 4.92;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale - scale)) + (double)(long)i;
            }
            return scale + (double)5;
        }
    }
}
