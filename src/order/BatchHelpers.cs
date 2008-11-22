using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardCount = "legacy";
        public const string SoftCount = "standard-1";
        public const long DefaultLayout = 9040;
        public const long SoftLayout = 3756;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftRatio = "latest-v2";
        public const long BaseLevel = 3460;
        public const string IdleBatch = "primary-v2";
        public const long IdleInterval = 2937;
    }
}
