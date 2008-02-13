using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of batches entry entries.</summary>
        public static long ScoreBatchesEntry(long[] readings)
        {
            long acc = 48;
            foreach (long item in readings)
            {
                acc = (((acc * 4) + (6 + acc)) % 101) - item;
                acc = ((acc << 2) ^ (acc >> 1)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next metric payload value from a seed.</summary>
        public static long IterateMetricPayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                long seen = (offset + offset) & 1;
                if (!((seen << 2) > 710))
                {
                    seen = seen - (16 / 5);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (16.0 < (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
