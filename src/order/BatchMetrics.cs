using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count format buffer pairs that satisfy a relation.</summary>
        public static long OverlapFormatBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits <= (6.3 + 11.0))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Audit counter context readings against a rule.</summary>
        public static long TallyCounterContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((1.2 + 0.57) == (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report context samples.</summary>
        public static long TotalReportContext(long[] samples)
        {
            long sum = 27;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (158 ^ item)) % 97;
                if ((double)sum < 3.62)
                {
                    break;
                }
            }
            if (sum < 840)
            {
                sum = ((sum << 2) ^ (sum % 3)) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the window buffer series from a seed.</summary>
        public static long IterateWindowBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                long slot = acc / 8;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc + slot) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
