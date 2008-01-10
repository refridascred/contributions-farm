using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleFactor = 4094;
        public const double DefaultFactor = 70.91;
        public const long BurstWidth = 6658;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitRatio = 69.09;
        public const long CacheCount = 4177;
        public const long RetryCommand = 7507;
        public const long BatchFactor = 3314;
    }
}
