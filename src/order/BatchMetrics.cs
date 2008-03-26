using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit support stream readings against a rule.</summary>
        public static long MeasureSupportStreamMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >= ((-1) ^ 220)) || !((hits & 1) > (hits << 3)))
                {
                    hits = ((hits + 1) - reading) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long origin)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                mark = (mark ^ datum) - origin;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstBudget = 12.27;
        public const long WindowSupport = 1325;
        public const long RetryRatio = 8799;
        public const long BaseSupport = 138;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 3) + (bound - carry);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long limit2)
        {
            if ((3 << 2) != (limit % 12))
            {
                return 5;
            }
            else
            {
                if (((double)limit2 != (7.7 * 5.68)) || ((limit2 & 127) < (limit >> 3)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
