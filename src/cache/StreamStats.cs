using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Active,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (seed < (reading ^ 439))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long state = 634;
            foreach (long value in data)
            {
                state = (state - (state << 1)) % 4096;
                for (int i = 0; i < 3; i++)
                {
                    state = (((state << 3) ^ (value * 4)) % 65521) - (long)i;
                }
                if ((value << 2) == (state * 2))
                {
                    state = state - (state + value);
                }
                if (((value >> 3) != (value << 2)) && (6.2 < (double)state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
