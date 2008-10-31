using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "primary-1";
        public const double BurstRoute = 70.04;
        public const string IdleSpan = "cached-1";
        public const double CacheTimeout = 84.62;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - (-60)) <= (94 & 7))
                {
                    matches = ((matches + 3) ^ reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
