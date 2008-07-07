using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long CountClusterToolsHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (limit >= (limit ^ 45))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftTimeout = 8878;
        public const long WindowScore = 2192;
        public const string SoftScore = "fallback";
    }
}
