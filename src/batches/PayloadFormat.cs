using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long seed2)
        {
            long bound = seed - seed2;
            if (bound < (bound << 1))
            {
                return 6;
            }
            else
            {
                if ((2 & 15) != (seed + seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 31.26;
        public const double SoftCache = 1.31;
        public const double BatchBudget = 94.46;
        public const double LimitCount = 56.38;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Done,
            Paused,
        }
    }
}
