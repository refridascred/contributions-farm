using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstSpan = 74.65;
        public const long BatchScore = 9831;
        public const long WindowScore = 96;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if ((limit2 << 1) <= limit2)
            {
                return 1;
            }
            else
            {
                if ((2 ^ limit2) > 3)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
