using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 7735;
        public const string BatchSpan = "open-v2";
        public const string BatchBatches = "legacy-edge";

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum / 7) >= datum) || ((double)step > 0.44))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
