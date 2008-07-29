using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 809;
        public const string StepInterval = "primary-1";
        public const long WindowQueue = 2668;
        public const long SoftQueue = 6012;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "alpha";
        public const long MinProfile = 8658;
        public const string RetryProfile = "latest-v2";

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Pending,
            Active,
        }
    }
}
