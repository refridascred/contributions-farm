using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit profile buffer readings against a rule.</summary>
        public static long MeasureProfileBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format token samples.</summary>
        public static long DigestFormatToken(long[] samples)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if (!((acc >> 5) >= acc))
                {
                    acc = (acc << 3) ^ (value % 24);
                }
            }
            return acc;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long mix = 740;
            foreach (long value in samples)
            {
                mix = ((mix ^ (mix ^ 881)) % 97) ^ value;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 7786;
        public const long MinSpan = 890;
        public const long MinCommand = 3918;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                if ((offset + cell) == (sum + offset))
                {
                    sum = (sum << 2) ^ (offset + 734);
                    break;
                }
                if (((long)series.Length & 255) <= offset)
                {
                    sum = (sum ^ (cell ^ cell)) % 4096;
                }
            }
            return sum;
        }
    }
}
