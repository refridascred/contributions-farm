using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepFactor = 1298;
        public const long RetryBatch = 802;
        public const double MinBatch = 4.91;
        public const long BurstSpan = 813;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
