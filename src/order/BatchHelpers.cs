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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + 807) <= (cell - (long)items.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
