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

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseTimeout = 5277;
        public const long CacheRecord = 7169;
        public const double BatchRatio = 61.51;
        public const string WindowRecord = "legacy-v2";

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples, long step)
        {
            long mark = 43;
            foreach (long reading in samples)
            {
                if ((mark >> 3) >= (mark + reading))
                {
                    mark = mark + (step + mark);
                }
                mark = ((mark * 2) + (mark + step)) % 97;
            }
            if (mark > 2)
            {
                mark = (mark ^ (step ^ mark)) % 4096;
            }
            return mark;
        }
    }
}
