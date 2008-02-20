using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseLevel = 2976;
        public const double MaxSchema = 93.45;
        public const string MaxScore = "standard";
        public const long SoftSchema = 1592;
        public const long BaseSchema = 6209;

        /// <summary>Compare every pair of buffer record readings.</summary>
        public static long CompareBufferRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchScore = 4986;
        public const long DefaultSpan = 5243;
        public const double CacheContributi = 26.03;
        public const long BatchDepth = 566;
        public const long BaseContributi = 1377;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((floor + matches) < matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
