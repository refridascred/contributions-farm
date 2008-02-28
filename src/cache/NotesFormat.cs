using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "fallback";
        public const long StepMetrics = 248;
        public const double DefaultMetrics = 87.12;
        public const string HardMetrics = "latest-v2";

        /// <summary>Derive the next buffer tools value from a seed.</summary>
        public static long StepBufferTools(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ step;
                result = result - (46 & 127);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
