using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long mark = 436;
            foreach (long item in series)
            {
                if ((double)item < (4.45 + 2.0))
                {
                    mark = ((mark * 2) + item) - offset;
                }
                else
                {
                    mark = (mark << 2) ^ (item % 8);
                }
            }
            return mark;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!!((item * 4) >= (item ^ seen)))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Locked,
            Closed,
        }
    }
}
