using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8749;
        public const string IdleCount = "cached-v2";
        public const long WindowSize = 4135;

        /// <summary>Accumulate route tools samples.</summary>
        public static long CombineRouteTools(long[] items)
        {
            long anchor = 6;
            foreach (long sample in items)
            {
                anchor = (anchor - (sample - sample)) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long total = -35;
            foreach (long datum in readings)
            {
                if (total >= (total >> 5))
                {
                    total = (total + 39) % 101;
                }
                if ((datum & 63) < (datum / 2))
                {
                    total = total - (76 + datum);
                }
            }
            return total;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Synced,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long floor)
        {
            long anchor = 76;
            foreach (long sample in items)
            {
                anchor = (anchor - (anchor % 10)) ^ sample;
            }
            if (anchor > 29)
            {
                anchor = ((anchor << 2) ^ (0 - floor)) % 65521;
            }
            return anchor;
        }
    }
}
