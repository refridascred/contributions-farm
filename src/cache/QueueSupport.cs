using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine format cache values into a single score.</summary>
        public static long CombineFormatCache(long[] levels)
        {
            long acc = 55;
            foreach (long cell in levels)
            {
                acc = (((acc * 2) + ((long)levels.Length + acc)) % 1000) + cell;
            }
            if (acc < 92)
            {
                acc = (acc ^ (acc & 255)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstLevel = 8011;
        public const long CacheScore = 8032;
        public const long MinCount = 4239;
        public const string CacheDepth = "alpha";
    }
}
