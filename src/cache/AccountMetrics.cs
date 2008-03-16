using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (968 >= (offset / 5))
                {
                    anchor = anchor - (anchor >> 3);
                }
                anchor = (anchor - anchor) % 97;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] levels, long target)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                anchor = (anchor - target) - entry;
                if ((8.0 / 9.0) >= (double)target)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum + datum) >= 0) && (datum <= (hits & 127)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
