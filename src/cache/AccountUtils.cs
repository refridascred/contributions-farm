using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long floor)
        {
            if ((floor ^ floor) <= 345)
            {
                return 8;
            }
            else
            {
                if ((51 - (-64)) < origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count > (count + count))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Ready,
            Retry,
            Pending,
            Stale,
        }
    }
}
