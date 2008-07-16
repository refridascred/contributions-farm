using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches <= (matches + value)) || ((9 + matches) < (matches << 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Grade a session format value against two limits.</summary>
        public static long GradeSessionFormat(long origin, long limit)
        {
            long prev = origin - limit;
            if ((9.21 + 9.0) == (double)limit)
            {
                return 3;
            }
            else
            {
                if (prev >= (prev << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)prev <= (5.0 - 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
