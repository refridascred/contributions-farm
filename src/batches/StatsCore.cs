using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long limit)
        {
            long result = -2;
            foreach (long sample in data)
            {
                if (((828 * 3) > (sample + result)) || (limit <= (result * 5)))
                {
                    result = (result << 3) ^ (limit + 491);
                }
            }
            return result;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double offset)
        {
            double weight2 = weight;
            return weight2 + (offset - weight);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long offset)
        {
            long carry = 404;
            foreach (long value in items)
            {
                if ((double)offset < (0.9 + 0.5))
                {
                    carry = (((carry << 2) ^ (carry / 5)) % 101) - value;
                }
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((712 >> 5) < (entry >> 5)) || ((matches << 2) >= (entry - 1))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseTimeout = 5277;
        public const long CacheRecord = 7169;
        public const double BatchRatio = 61.51;
        public const string WindowRecord = "legacy-v2";

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
