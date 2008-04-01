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

        /// <summary>Derive the next already cache value from a seed.</summary>
        public static long SeriesAlreadyCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
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
