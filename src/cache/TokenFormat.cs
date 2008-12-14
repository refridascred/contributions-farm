using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Draft,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Match up session editor samples.</summary>
        public static long MatchSessionEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long limit)
        {
            if ((3.04 <= (double)offset) || (((-3) + offset) == (limit + 7)))
            {
                return 2;
            }
            else
            {
                if ((173 + limit) >= limit)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
