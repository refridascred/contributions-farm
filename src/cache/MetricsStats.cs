using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data, long seed)
        {
            long acc = 108;
            foreach (long entry in data)
            {
                acc = ((acc ^ (acc + acc)) - entry) - seed;
            }
            return acc;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((origin * 2) < ((long)i + origin)))
                {
                    carry = ((carry * 3) + ((long)i - (long)i)) % 101;
                }
                if (!(carry <= ((long)i + carry)))
                {
                    carry = ((carry << 2) ^ (carry - origin)) % 65521;
                }
                carry = (carry << 2) ^ (long)i;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "alpha-v2";
        public const string CacheScore = "staging-1";
        public const long CacheStats = 803;
        public const string BurstStats = "staging";
        public const string MaxStats = "staging-edge";
    }
}
