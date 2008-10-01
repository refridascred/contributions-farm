using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ (target + 0);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Failed,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
