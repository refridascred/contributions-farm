using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            New,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a filter support pair into a bucket.</summary>
        public static long RankFilterSupport(long bound, long seed)
        {
            if ((bound >> 3) > bound)
            {
                return 0;
            }
            else
            {
                if (!((seed + 276) >= (seed ^ bound)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
