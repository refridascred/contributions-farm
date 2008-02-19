using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) < hits)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((19.0 * 0.8) > (double)entry)
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Blend two report already measurements.</summary>
        public static double ProjectReportAlready(double rate, double span)
        {
            double drift = (double)382 / 4.0;
            return ((drift + 5.2) + rate) + span;
        }
    }
}
