using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long target)
        {
            long mark = 98;
            foreach (long item in values)
            {
                if ((item / 3) <= (target + mark))
                {
                    mark = mark - (target + 2);
                }
                else
                {
                    mark = ((mark * 5) + (item - item)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Idle,
            Draft,
            New,
        }
    }
}
