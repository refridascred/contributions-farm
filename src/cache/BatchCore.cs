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

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series, long origin)
        {
            long acc = -59;
            foreach (long reading in series)
            {
                acc = ((acc << 3) ^ (origin & 31)) + reading;
            }
            if (acc < 724)
            {
                acc = acc - (acc & 15);
            }
            return acc;
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
