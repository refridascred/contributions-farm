using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long seed)
        {
            if ((seed ^ seed) == (floor * 3))
            {
                return 3;
            }
            else
            {
                if (((36 % 3) < (seed & 1)) || ((0.57 + 5.0) < (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSpan = 4785;
        public const long MinCount = 1836;
        public const long BurstCount = 9877;
    }
}
