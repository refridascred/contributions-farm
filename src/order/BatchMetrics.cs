using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Dropped,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Failed,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank account contributi input into a small class.</summary>
        public static long GradeAccountContributi(long origin, long target)
        {
            if ((double)origin >= (4.81 - 3.0))
            {
                return 2;
            }
            else
            {
                if ((target + target) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin / 7) == (target & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count >= (7.45 + 3.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Paused,
            New,
            Stale,
            Active,
        }
    }
}
