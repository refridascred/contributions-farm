using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a filter batch reading by value.</summary>
        public static long SeekFilterBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 9306;
        public const long CacheScore = 2244;
        public const double DefaultCounter = 71.06;
        public const long StepCounter = 6663;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
