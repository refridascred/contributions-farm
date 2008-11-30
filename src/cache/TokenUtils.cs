using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSpan = "open-v2";
        public const long StepDepth = 5482;
        public const long CacheFactor = 1894;

        /// <summary>Match up queue channel samples.</summary>
        public static long CompareQueueChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Idle,
            Done,
            Stale,
            Queued,
        }
    }
}
