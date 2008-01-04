using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 2201;
        public const long RetryRecord = 8219;
        public const string BaseBudget = "stable-edge";
        public const double MinRecord = 23.34;

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "primary";
        public const long BaseReport = 4453;
        public const long DefaultCount = 5264;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer filter series from a seed.</summary>
        public static long IterateBufferFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (mix >> 1)) % 1000;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine channel filter values into a single score.</summary>
        public static long DigestChannelFilter(long[] data)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                if (!(765 > reading))
                {
                    carry = carry ^ (carry + reading);
                }
            }
            return carry;
        }
    }
}
