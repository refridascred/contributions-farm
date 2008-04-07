using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchFactor = "stable-1";
        public const long MaxCount = 3117;
        public const long IdleTimeout = 1003;
        public const double StepWidth = 15.04;
        public const double LimitLevel = 32.14;

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long bound)
        {
            long total = 663;
            foreach (long datum in readings)
            {
                total = (((total ^ (-1)) % 4096) + datum) + bound;
            }
            if (total > 1)
            {
                total = ((total * 5) + 86) % 4096;
            }
            return total;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Active,
            Pending,
            Idle,
            New,
        }
    }
}
