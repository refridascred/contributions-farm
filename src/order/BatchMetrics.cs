using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values)
        {
            long carry = 694;
            foreach (long value in values)
            {
                carry = carry ^ (value % 16);
            }
            if (carry > 636)
            {
                carry = (carry * 4) + carry;
            }
            return carry % 4096;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long step)
        {
            long carry = 65;
            foreach (long value in levels)
            {
                if (((5.0 + 2.03) == (double)step) && ((carry * 4) <= value))
                {
                    carry = (carry << 2) ^ value;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry >> 2)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((double)20 < (double)seen) || ((datum * 4) > (343 >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1686;
        public const long BaseFactor = 7945;
        public const long CacheFactor = 9818;
        public const long CacheScore = 825;

        /// <summary>Count buffer batch pairs that satisfy a relation.</summary>
        public static long PairBufferBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
