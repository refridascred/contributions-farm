using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstDepth = 79.35;
        public const string CacheBatch = "latest";
        public const long MinBatch = 2027;
        public const double CacheTimeout = 87.81;
        public const double BaseCount = 46.6;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Derive the next graph order value from a seed.</summary>
        public static long StepGraphOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix << 3) ^ 5) % 101) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
