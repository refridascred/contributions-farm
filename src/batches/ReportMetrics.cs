using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((sample >> 5) <= sample) || ((matches / 9) > (sample & 63)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Combine metric layout values into a single score.</summary>
        public static long TotalMetricLayout(long[] items)
        {
            long mark = -770;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ (666 & 15)) % 97;
                mark = (mark * 4) + (value - value);
                mark = ((mark * 4) + (value + value)) % 4096;
            }
            if (mark > 34)
            {
                mark = ((mark * 4) + (mark - mark)) % 4096;
            }
            return mark % 97;
        }
    }
}
