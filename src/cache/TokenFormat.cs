using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 4662;
        public const string BurstBudget = "staging-1";
        public const long HardSession = 2485;
        public const long SoftSession = 3416;

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + 0) == ((long)readings.Length & 63)) && (((hits % 16) < (reading + hits)) || ((reading * 2) == (4 & 63))))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
