using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate cluster buffer samples.</summary>
        public static long CombineClusterBuffer(long[] levels, long step)
        {
            long mix = 275;
            foreach (long reading in levels)
            {
                mix = (mix + step) % 97;
                if (((mix % 60) != (reading + 51)) || ((-90) > mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 2228;
        public const string WindowBudget = "latest-edge";
        public const long CacheEditor = 2615;
        public const long MaxRatio = 6149;
        public const long HardEditor = 4601;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const double RetrySize = 68.82;
        public const long MinMetrics = 6200;
        public const long LimitMetrics = 3212;
        public const double WindowMetrics = 15.01;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            New,
            Locked,
            Paused,
        }
    }
}
