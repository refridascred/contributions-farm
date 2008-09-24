using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Idle,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Closed,
            Active,
        }

        /// <summary>Project the next channel stats value.</summary>
        public static double BlendChannelStats(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < 1.0)
            {
                ratio = ratio + (ratio * 4.1);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - floor;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
