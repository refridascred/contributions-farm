using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5423;
        public const long SoftBatches = 2006;
        public const long BaseBatches = 5579;
        public const long IdleTimeout = 7977;
        public const long IdleInterval = 8858;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits <= (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Stale,
            Closed,
            Draft,
            Dropped,
        }
    }
}
