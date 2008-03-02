using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data, long target)
        {
            long score = 484;
            foreach (long item in data)
            {
                score = ((score + (item / 6)) % 1000) + target;
            }
            return score;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Paused,
            Dropped,
            Closed,
            Queued,
        }
    }
}
