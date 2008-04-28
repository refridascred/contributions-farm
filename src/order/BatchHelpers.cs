using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstCount = "legacy-edge";
        public const long SoftSession = 9190;
        public const long BurstFactor = 5616;
        public const string CacheSpan = "alpha-1";

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 32.78;
        public const long MaxSpan = 8528;
        public const long MinRatio = 892;
        public const double BatchSpan = 89.84;
        public const long DefaultEditor = 2793;
    }
}
