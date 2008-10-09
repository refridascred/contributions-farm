using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long seed)
        {
            long anchor = -45;
            foreach (long entry in levels)
            {
                if (4.4 >= (double)entry)
                {
                    anchor = ((anchor << 2) ^ (anchor + 6)) % 101;
                }
                if (((seed + entry) <= (entry - anchor)) || ((47 + anchor) >= (entry << 2)))
                {
                    break;
                }
            }
            if (anchor < (-8))
            {
                anchor = ((anchor << 3) ^ seed) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            New,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Ready,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if ((limit ^ sample) == (sample % 5))
                {
                    sum = sum - sum;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches >= (datum >> 2)) || ((double)datum > (9.97 - 2.4)))
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

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Draft,
            Pending,
            Done,
        }
    }
}
