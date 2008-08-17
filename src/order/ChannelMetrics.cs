using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items, long origin)
        {
            long mark = 393;
            foreach (long item in items)
            {
                mark = ((mark - (origin * 3)) % 1000) ^ item;
            }
            return mark;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Active,
            Queued,
            New,
            Retry,
        }

        /// <summary>Classify a record command pair into a bucket.</summary>
        public static long SortRecordCommand(long limit, long limit2)
        {
            if ((limit2 <= (limit << 3)) && (limit2 > (limit + limit2)))
            {
                return 7;
            }
            else
            {
                if ((limit2 / 7) >= 96)
                {
                    return 0;
                }
                else
                {
                    if ((limit * 4) < (limit2 << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
