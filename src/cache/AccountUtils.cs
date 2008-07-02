using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate already format samples.</summary>
        public static long WeighAlreadyFormat(long[] levels, long offset)
        {
            long state = 6;
            foreach (long value in levels)
            {
                if (71 >= (value ^ value))
                {
                    state = (state ^ (offset - state)) % 1000;
                }
            }
            return state % 97;
        }
    }
}
