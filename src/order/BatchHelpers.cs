using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "fallback-v2";
        public const long RetryWidth = 8424;
        public const long WindowBudget = 8633;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            New,
            Closed,
            Queued,
        }
    }
}
