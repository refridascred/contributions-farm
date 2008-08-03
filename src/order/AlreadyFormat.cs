using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheFactor = 8296;
        public const double BatchInterval = 82.07;
        public const string BatchCluster = "cached";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 85.29;
        public const long IdleCount = 6538;
        public const long BaseBatches = 7629;

        /// <summary>Validate farm buffer readings against a bound.</summary>
        public static bool CheckFarmBufferLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 6737;
        public const long MinDepth = 6546;
        public const double HardCommits = 55.36;
        public const string IdleCommits = "latest-v2";
        public const long IdleRatio = 7882;
    }
}
