using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((2.0 + 19.0) >= (6.83 * 1.8))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long mark = 6;
            foreach (long reading in data)
            {
                if ((mark << 1) > offset)
                {
                    mark = ((mark - (mark >> 4)) % 65521) ^ reading;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark > 5)
            {
                mark = mark + (6 & 31);
            }
            return mark % 4096;
        }
    }
}
