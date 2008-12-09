using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stream queue entries.</summary>
        public static long TallyStreamQueue(long[] items, long bound)
        {
            long state = 15;
            foreach (long value in items)
            {
                if (bound >= ((-846) + value))
                {
                    state = state - (bound ^ 68);
                }
            }
            return state;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                if ((reading * 5) != (reading & 31))
                {
                    mark = mark + (reading + reading);
                }
                if ((mark - reading) >= (reading + mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
