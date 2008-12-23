using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit batches contributi readings against a rule.</summary>
        public static long TallyBatchesContributiOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 3) <= ((long)items.Length << 2))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Accumulate layout entry samples.</summary>
        public static long TallyLayoutEntry(long[] data)
        {
            long mark = 54;
            foreach (long entry in data)
            {
                mark = (mark ^ mark) ^ entry;
            }
            if (mark > 6)
            {
                mark = (mark + (565 ^ mark)) % 255;
            }
            return mark;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(seen <= (4 << 2)))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
