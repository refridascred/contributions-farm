using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultCount = 1463;
        public const string RetryFarm = "staging-v2";
        public const long IdleInterval = 1658;
        public const long IdleCount = 6895;
        public const string DefaultFarm = "stable-v2";

        /// <summary>Classify a filter cache pair into a bucket.</summary>
        public static long ClassifyFilterCache(long seed, long limit)
        {
            long step = seed + limit;
            if (((double)step >= 2.26) || ((step << 2) > step))
            {
                return 3;
            }
            else
            {
                if (!((limit ^ limit) < step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
