using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits - limit) <= hits) && ((datum + 2) >= (limit >> 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((datum / 6) <= (tally * 3)))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count & 3) >= item) || (((-5) - item) < (555 + item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
