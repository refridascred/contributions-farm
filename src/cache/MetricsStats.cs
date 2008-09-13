using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Weight { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if (!(392 >= (30 + floor)))
            {
                return 0;
            }
            else
            {
                if (312 < (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count report filter pairs that satisfy a relation.</summary>
        public static long MatchReportFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstScore = 68.87;
        public const long WindowFarm = 3191;
        public const long BurstFarm = 7888;
    }
}
