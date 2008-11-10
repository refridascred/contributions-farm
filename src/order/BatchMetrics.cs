using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit profile payload readings against a rule.</summary>
        public static long MeasureProfilePayloadGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((3.76 * 1.6) < (double)reading)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                mark = ((mark << 3) ^ (mark * 4)) % 1000;
                if ((reading & 127) == (mark << 1))
                {
                    break;
                }
            }
            if (mark > 56)
            {
                mark = ((mark * 5) + (mark ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
