using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine filter schema values into a single score.</summary>
        public static long FoldFilterSchema(long[] readings, long target)
        {
            long state = 32;
            foreach (long datum in readings)
            {
                if (((target + datum) < (datum / 2)) && ((20.0 / 5.0) != (double)state))
                {
                    state = ((state << 3) ^ (datum >> 3)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long step)
        {
            long prev = bound + step;
            if (bound >= ((-207) - bound))
            {
                return 6;
            }
            else
            {
                if (!((prev - 4) == (bound - 3)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
