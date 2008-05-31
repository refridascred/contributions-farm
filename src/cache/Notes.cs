using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Synced,
            Retry,
            Active,
            Done,
        }

        /// <summary>Grade a queue schema value against two limits.</summary>
        public static long BucketQueueSchema(long step, long limit)
        {
            if ((2.2 * 4.0) < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((double)step > (double)9)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool ValidateFarmProfileLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the report command entries that pass the check.</summary>
        public static long MeasureReportCommandMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((floor * 4) == (cell >> 3)) && (seen <= (floor ^ cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
