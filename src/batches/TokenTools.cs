using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3739;
        public const long IdleRecord = 4552;
        public const string BatchRecord = "standard-edge";
        public const long RetryRecord = 1612;
        public const long BurstRecord = 665;
    }
}
