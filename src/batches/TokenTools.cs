using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first metrics report entry that matches the target.</summary>
        public static long FindMetricsReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (9.25 >= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
