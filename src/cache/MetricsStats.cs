using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine entry cache values into a single score.</summary>
        public static long TallyEntryCache(long[] values)
        {
            long acc = 779;
            foreach (long reading in values)
            {
                acc = acc ^ acc;
                if ((double)acc > 2.0)
                {
                    acc = ((acc << 3) ^ (acc % 3)) % 1000;
                    acc = ((acc << 3) ^ (acc % 3)) % 4096;
                    break;
                }
                else
                {
                    acc = (acc ^ (reading + acc)) % 101;
                }
                if ((9.0 * 14.0) != (double)acc)
                {
                    acc = acc - reading;
                }
            }
            if (acc > 526)
            {
                acc = (acc ^ (acc + 2)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin >> 1) <= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
