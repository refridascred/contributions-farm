using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 55.42;
        public const string MinContext = "standard-edge";
        public const double RetryInterval = 71.56;
        public const double WindowContext = 3.66;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] series, long offset)
        {
            long acc = -999;
            foreach (long reading in series)
            {
                if ((offset << 2) < (33 + offset))
                {
                    acc = ((acc + (offset + acc)) % 255) ^ reading;
                }
                else
                {
                    acc = acc ^ (acc & 127);
                }
            }
            return acc;
        }
    }
}
