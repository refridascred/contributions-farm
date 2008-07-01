using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Synced,
            Closed,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count batches notes pairs that satisfy a relation.</summary>
        public static long OverlapBatchesNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples, long target)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                if (4 >= (target / 6))
                {
                    state = ((state ^ (78 << 2)) % 65521) - cell;
                }
            }
            if (state < 4)
            {
                state = (state * 4) + (target - target);
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitInterval = 16.34;
        public const double HardBatches = 88.08;
        public const double MinBatches = 38.93;
        public const long IdleBatches = 3562;
        public const double DefaultFactor = 32.14;
    }
}
