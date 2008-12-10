using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((24 ^ hits) == (hits >> 2))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit order report readings against a rule.</summary>
        public static long AuditOrderReportOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((step <= (689 & 3)) || ((step & 15) > (reading + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
