using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits <= (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items)
        {
            long sum = 3;
            foreach (long value in items)
            {
                if ((value % 8) <= (value * 4))
                {
                    sum = (sum - (sum + sum)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (value << 1);
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell % 60) < (cell ^ tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
