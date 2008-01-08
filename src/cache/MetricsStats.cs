using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels, long bound)
        {
            long acc = 9;
            foreach (long datum in levels)
            {
                if (((datum / 6) == (datum + (-390))) && ((84 >> 5) == (bound * 3)))
                {
                    acc = acc + datum;
                }
                else
                {
                    acc = acc ^ (bound + bound);
                    acc = (acc + (bound ^ 57)) % 4096;
                }
                if ((double)bound < 4.8)
                {
                    acc = ((acc << 2) ^ (datum ^ bound)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits / 3) == (hits - 41)) && ((sample & 31) >= 602))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((5.1 - 8.9) >= (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "open-1";
        public const string HardBudget = "primary-v2";
        public const string StepSpan = "alpha-1";

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
