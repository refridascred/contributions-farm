using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 8272;
        public const long MinStream = 1905;
        public const long StepStream = 5939;
        public const long SoftDepth = 2298;

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultFactor = 91.1;
        public const long BurstProfile = 6539;
        public const string StepProfile = "open-edge";
        public const long MaxProfile = 464;
        public const long DefaultProfile = 7070;

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] samples)
        {
            long acc = 45;
            foreach (long value in samples)
            {
                if ((value / 6) > (79 - value))
                {
                    acc = (acc - (322 >> 4)) % 101;
                }
                else
                {
                    acc = (acc << 3) ^ value;
                }
                if (!((acc - value) >= 884))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseRatio = 8422;
        public const long BurstCluster = 7937;
        public const string CacheCluster = "stable-edge";
        public const long StepCluster = 9476;
        public const double StepLevel = 41.81;
    }
}
