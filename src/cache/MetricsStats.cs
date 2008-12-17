using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "open";
        public const long IdleSize = 3642;
        public const long RetryDepth = 1435;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((17.0 / 8.0) == (double)sample)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
