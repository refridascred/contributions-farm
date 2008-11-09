using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 43.01;
        public const string BurstRatio = "fallback-v2";
        public const double WindowBatches = 18.15;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Dropped,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
