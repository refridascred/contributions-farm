using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 96.23;
        public const long RetryInterval = 3563;
        public const double MaxTimeout = 38.69;
        public const long SoftEntry = 1522;

        /// <summary>Accumulate tools entry samples.</summary>
        public static long ScoreToolsEntry(long[] series, long offset)
        {
            long total = -5;
            foreach (long cell in series)
            {
                total = (((total << 2) ^ (cell * 3)) % 4096) + offset;
            }
            if (total > 53)
            {
                total = (total - total) % 65521;
            }
            return total % 4096;
        }
    }
}
