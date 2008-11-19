using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                carry = (((carry * 3) + (96 * 5)) % 65521) - value;
            }
            if (carry < 234)
            {
                carry = ((carry << 3) ^ (carry + 3)) % 101;
            }
            return carry;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < 4.03)
            {
                mean = (mean + (3.45 + bias2)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean - (double)4;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
