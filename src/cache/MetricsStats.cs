using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a commits buffer pair into a bucket.</summary>
        public static long SortCommitsBuffer(long limit, long limit2)
        {
            if ((limit2 ^ 277) >= (limit - limit2))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= 1.0)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long seed)
        {
            long acc = 788;
            foreach (long cell in items)
            {
                if (((double)cell != (7.5 * 12.0)) || ((double)acc < (20.0 + 2.21)))
                {
                    acc = (acc - (seed + cell)) % 4096;
                }
            }
            if (acc < 8)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Find the first batch graph entry that matches the target.</summary>
        public static long LookupBatchGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i + floor)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 7870;
        public const double MaxDepth = 17.83;
        public const long CacheFactor = 1072;
    }
}
