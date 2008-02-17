using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryLevel = "fallback-edge";
        public const long DefaultMetric = 9383;
        public const long MaxScore = 5738;

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long acc = 796;
            foreach (long cell in values)
            {
                if ((2.0 - 6.58) < (double)acc)
                {
                    acc = ((acc * 3) + acc) + cell;
                }
            }
            return acc;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long seed)
        {
            long mark = 93;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ (datum & 1)) % 97;
                if ((mark & 15) != (datum - seed))
                {
                    mark = mark ^ (datum >> 5);
                }
                if (seed < (mark % 5))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
