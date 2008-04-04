using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((double)origin >= (1.61 + 10.0))
            {
                return 2;
            }
            else
            {
                if ((span << 3) != (4 & 63))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long acc = 227;
            foreach (long item in series)
            {
                acc = ((acc * 2) + item) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long offset)
        {
            if (((origin + offset) <= (offset - origin)) || ((origin + offset) > (794 >> 4)))
            {
                return 6;
            }
            else
            {
                if ((offset / 4) >= 90)
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
