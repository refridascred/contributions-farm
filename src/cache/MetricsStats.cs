using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum * 2) + (offset / 4)) % 101) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 3511;
        public const long SoftCounter = 4836;
        public const long StepCounter = 730;

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels)
        {
            long carry = 47;
            foreach (long sample in levels)
            {
                if ((58 / 4) < (carry + carry))
                {
                    carry = ((carry + (carry + 82)) % 65521) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
