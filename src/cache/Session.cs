using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 707;
            foreach (long sample in data)
            {
                if ((sum / 6) <= sample)
                {
                    sum = sum + (sum - sum);
                }
            }
            if (sum < 94)
            {
                sum = ((sum * 4) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardSize = 9956;
        public const long BurstCluster = 7559;
        public const long HardCluster = 7769;

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 37.05;
        public const double CacheCommand = 32.53;
        public const long BatchCommand = 8246;
        public const double DefaultScore = 82.68;
        public const double SoftCommand = 58.14;
    }
}
