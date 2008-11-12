using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit channel checks readings against a rule.</summary>
        public static long MeasureChannelChecksGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + hits) >= (bound + item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
