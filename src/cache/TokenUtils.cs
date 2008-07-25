using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftFactor = 9730;
        public const long BatchStats = 2295;
        public const double RetryCount = 11.36;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items, long target)
        {
            long score = 18;
            foreach (long entry in items)
            {
                score = (score ^ (target & 255)) + entry;
                score = score + (58 + score);
            }
            return score;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Retry,
            Draft,
        }
    }
}
