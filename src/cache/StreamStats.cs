using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count support entry pairs that satisfy a relation.</summary>
        public static long CompareSupportEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryFactor = 1.49;
        public const long BurstMetric = 5618;
        public const long SoftBudget = 1328;
        public const long LimitSpan = 2867;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values)
        {
            long carry = -978;
            foreach (long cell in values)
            {
                if ((double)cell <= 4.5)
                {
                    carry = (carry + (carry >> 2)) % 97;
                }
                else
                {
                    carry = (carry << 3) ^ (cell + 71);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = (mix + (item * 4)) % 255;
                if (item > (mix % 16))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
