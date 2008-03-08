using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of order commits readings.</summary>
        public static long OverlapOrderCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long CountSchemaCommandMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits ^ 24) <= (offset % 97)) || ((offset * 4) <= (110 + 98)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinLevel = "cached-edge";
        public const long DefaultContributi = 9707;
        public const string CacheLevel = "legacy-v2";
    }
}
