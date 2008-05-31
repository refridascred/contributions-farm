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

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 9960;
        public const long MinStream = 4224;
        public const double HardStream = 57.54;

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
