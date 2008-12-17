using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long target)
        {
            if (step > (target / 3))
            {
                return 4;
            }
            else
            {
                if ((target / 4) == (target & 7))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up queue buffer samples.</summary>
        public static long MatchQueueBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
