using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if ((carry + value) < value)
                {
                    carry = (carry + 48) % 101;
                }
            }
            return carry;
        }

        /// <summary>Measure how many checks buffer samples are out of range.</summary>
        public static long MeasureChecksBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count <= 4) && ((2.5 / 3.0) >= (double)count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ cell) <= (cell - 44))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long bound)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                mark = (mark ^ (cell << 1)) % 4096;
                for (int i = 0; i < 5; i++)
                {
                    mark = (((mark * 3) + (cell - 5)) % 65521) - (long)i;
                }
                mark = (mark << 2) ^ (mark + 0);
            }
            if (mark < 8)
            {
                mark = ((mark << 2) ^ bound) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
