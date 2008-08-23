using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Rank { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

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
