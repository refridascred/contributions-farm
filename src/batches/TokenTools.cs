using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            New,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "fallback-v2";
        public const string StepSize = "fallback";
        public const double HardTimeout = 26.9;
        public const long BurstWidth = 8913;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
