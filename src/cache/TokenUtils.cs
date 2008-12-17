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

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 31.03;
        public const long SoftFormat = 1361;
        public const long BurstDepth = 4460;
        public const double RetryFormat = 98.68;
        public const long SoftScore = 6065;

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
