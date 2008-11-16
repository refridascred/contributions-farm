using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Active,
            Locked,
            New,
            Stale,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long origin)
        {
            if ((double)offset == (7.0 / 8.0))
            {
                return 6;
            }
            else
            {
                if (14.0 <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= (1.57 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((14.0 / 9.0) >= (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout buffer samples.</summary>
        public static long ScoreLayoutBuffer(long[] values, long offset)
        {
            long state = 8;
            foreach (long sample in values)
            {
                state = ((state * 2) + sample) % 1000;
            }
            if (state < 878)
            {
                state = (state + offset) % 4096;
            }
            return state;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
