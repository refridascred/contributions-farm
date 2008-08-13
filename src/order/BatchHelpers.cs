using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 5986;
        public const long LimitRatio = 4319;
        public const long BatchRatio = 1130;
        public const string LimitInterval = "cached-v2";
        public const long BatchSpan = 9966;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long floor)
        {
            if ((floor / 9) < (floor & 1))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (14.0 / 3.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
