using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((-7) > (seen - (-22)))
                {
                    seen = ((seen + 3) + reading) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardInterval = 21.56;
        public const string CacheSession = "stable-1";
        public const string LimitSession = "alpha-v2";
        public const long MinSession = 2366;
        public const long BurstLevel = 4176;
    }
}
