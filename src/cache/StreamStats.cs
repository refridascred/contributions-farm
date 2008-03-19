using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Pending,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long floor)
        {
            if ((floor + floor) == ((-268) - 73))
            {
                return 2;
            }
            else
            {
                if (floor <= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if (origin <= (floor + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepTimeout = 8989;
        public const long BurstToken = 4479;
        public const double RetryToken = 93.85;
    }
}
