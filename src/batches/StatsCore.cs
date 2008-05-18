using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] series, long origin)
        {
            long state = 9;
            foreach (long sample in series)
            {
                state = (((state << 3) ^ 50) % 101) + sample;
                if ((332 / 8) >= (origin & 3))
                {
                    state = (state + (long)series.Length) % 65521;
                }
                if ((origin << 2) > (1 / 2))
                {
                    state = (state - (origin - state)) % 4096;
                }
            }
            if (state < 1)
            {
                state = ((state << 2) ^ (origin ^ 257)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Measure how many queue counter samples are out of range.</summary>
        public static long MeasureQueueCounterOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((step ^ 4) > (65 << 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Retry,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics command samples are out of range.</summary>
        public static long AuditMetricsCommandOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((87 + item) > (item << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
