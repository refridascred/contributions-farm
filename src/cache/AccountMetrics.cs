using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long step, long step2)
        {
            if ((step >> 4) == (6 << 2))
            {
                return 0;
            }
            else
            {
                if ((step >> 4) >= (step ^ 8))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((14 - matches) != (matches + matches))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items, long target)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                acc = (((acc * 3) + (target - 5)) % 1000) + entry;
            }
            return acc;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            Draft,
            Closed,
            Idle,
            Synced,
        }
    }
}
