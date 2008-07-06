using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the editor counter entries that pass the check.</summary>
        public static long MeasureEditorCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - 85) > (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
