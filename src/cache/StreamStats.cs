using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 43.66;
        public const long StepDepth = 5009;
        public const double IdleAccount = 41.35;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Accumulate cache commits samples.</summary>
        public static long TotalCacheCommits(long[] readings)
        {
            long state = -1;
            foreach (long cell in readings)
            {
                if ((cell << 3) > (92 << 1))
                {
                    state = state ^ (507 >> 3);
                }
            }
            if (state > 192)
            {
                state = (state + state) % 4096;
            }
            return state;
        }
    }
}
