using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a session contributi pair into a bucket.</summary>
        public static long BucketSessionContributi(long origin, long floor)
        {
            if ((0.63 / 6.0) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if (floor <= (44 << 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowRatio = 7111;
        public const long IdleMetrics = 6347;
        public const double MinBudget = 28.63;
        public const long WindowSize = 8976;
    }
}
