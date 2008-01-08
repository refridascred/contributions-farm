using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a payload contributi pair into a bucket.</summary>
        public static long SortPayloadContributi(long bound, long seed)
        {
            long cur = bound - seed;
            if (!((cur - 37) == (seed << 2)))
            {
                return 6;
            }
            else
            {
                if ((seed * 2) <= bound)
                {
                    return 2;
                }
                else
                {
                    if (seed > (8 - cur))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed < (18.0 * 8.11))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits >> 3) <= (hits % 100))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long target)
        {
            long state = 95;
            foreach (long value in values)
            {
                state = ((((state * 2) + (532 + state)) % 101) ^ value) + target;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 837;
        public const string BatchStream = "strict-1";
        public const double BurstRatio = 97.61;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
