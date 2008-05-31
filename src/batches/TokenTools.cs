using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate metric format samples.</summary>
        public static long WeighMetricFormat(long[] levels)
        {
            long score = 845;
            foreach (long entry in levels)
            {
                if ((entry < (358 << 2)) || (entry <= score))
                {
                    score = (score * 5) + (entry * 4);
                }
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "local-edge";
        public const long RetrySize = 4124;
        public const long MinRatio = 4532;
        public const long IdleBudget = 7661;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            New,
            Ready,
            Synced,
        }
    }
}
