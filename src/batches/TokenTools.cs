using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches % 8) <= (matches - matches))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryTimeout = "legacy-edge";
        public const string BatchPayload = "primary-1";
        public const string HardPayload = "cached";
        public const long RetryPayload = 8177;

        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long CompareBufferContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
