using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Failed,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items, long floor)
        {
            long score = -437;
            foreach (long entry in items)
            {
                if ((entry * 3) > ((long)items.Length + entry))
                {
                    score = (((score << 2) ^ (entry << 2)) % 4096) - floor;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Paused,
            Closed,
            Pending,
            Queued,
        }
    }
}
