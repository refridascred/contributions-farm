using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 47.13;
        public const double BaseFormat = 82.21;
        public const long BurstSize = 9190;
        public const string DefaultCount = "cached-1";
        public const long MinFormat = 5892;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Dropped,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Count metrics entry pairs that satisfy a relation.</summary>
        public static long CompareMetricsEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
