using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 3239;
        public const long BurstScore = 3082;
        public const double MinDepth = 84.37;
        public const long BatchSession = 9300;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinTimeout = 2739;
        public const string MinContributi = "strict-1";
        public const double HardContributi = 24.92;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
