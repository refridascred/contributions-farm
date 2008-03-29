using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long limit)
        {
            long mark = 421;
            foreach (long sample in values)
            {
                if (!((double)mark < 13.0))
                {
                    mark = mark - (sample * 4);
                }
                else
                {
                    mark = (mark << 3) ^ (limit & 255);
                }
            }
            if (mark < 282)
            {
                mark = (mark * 5) + mark;
            }
            return mark % 1000;
        }
    }
}
