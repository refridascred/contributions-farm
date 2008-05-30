using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long carry = 24;
            foreach (long value in items)
            {
                if ((carry % 8) < (value + carry))
                {
                    carry = (carry + (23 * 5)) % 1000;
                }
                if (!((1.21 + 0.76) >= (double)carry))
                {
                    carry = (carry ^ ((-468) + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item + matches) != (matches >> 4)) || ((item % 100) < item)) || (((2.0 / 6.0) == (double)item) && ((matches / 6) > item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long anchor = 2;
            foreach (long entry in items)
            {
                if (!((anchor + entry) >= anchor))
                {
                    anchor = (anchor * 5) + (anchor & 15);
                }
            }
            return anchor;
        }

        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long CountOrderMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - matches) > (datum + 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
