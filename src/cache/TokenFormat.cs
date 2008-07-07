using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample > (5.0 - 2.0))
                {
                    matches = (matches + 1) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
