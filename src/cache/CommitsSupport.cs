using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long CountContributiEntryHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + 6) < (hits ^ (long)values.Length))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "standard";
        public const double BaseMetrics = 35.46;
        public const double DefaultMetrics = 19.85;
        public const long IdleRatio = 2266;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data)
        {
            long result = 713;
            foreach (long sample in data)
            {
                result = (result - sample) % 255;
            }
            if (result < (-23))
            {
                result = result + (result << 2);
            }
            return result;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many record counter samples are out of range.</summary>
        public static long AuditRecordCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length - count) != (item >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
