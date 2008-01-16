using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long origin)
        {
            long cur = step - origin;
            if (((step * 4) <= (cur ^ origin)) || ((2.0 * 15.0) >= (double)step))
            {
                return 2;
            }
            else
            {
                if (((6.97 - 4.9) >= (double)origin) || ((step % 3) <= (origin ^ origin)))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 3) == (origin + 76))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((45 + entry) >= (seen ^ entry))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Ready,
            Retry,
        }
    }
}
