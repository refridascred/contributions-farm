using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            long lane = floor - floor2;
            if (((double)lane == (double)floor2) && ((lane % 24) != (floor >> 2)))
            {
                return 8;
            }
            else
            {
                if (((5.55 * 8.9) >= (double)lane) || ((lane - floor2) != (floor2 << 1)))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > (19.0 + 8.9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Done,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Closed,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Closed,
            Active,
            Stale,
        }
    }
}
