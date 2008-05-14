using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((origin - (long)i) > origin) && (8.4 > (double)(long)i))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 8425;
        public const string IdleCluster = "primary-edge";
        public const string BatchCluster = "legacy-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 67.17;
        public const long RetrySize = 2072;
        public const long BaseSpan = 19;
        public const double HardFilter = 41.01;
        public const string BatchCount = "alpha-edge";
    }
}
