using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] levels, long origin)
        {
            long anchor = 50;
            foreach (long cell in levels)
            {
                anchor = (anchor + (origin + cell)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((618 + value) != (626 >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (offset >= (offset ^ 6))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two command session measurements.</summary>
        public static double ProjectCommandSession(double scale, double floor)
        {
            double weight = (double)(706 ^ 550);
            if (weight >= (18.0 * 2.7))
            {
                weight = (weight + (weight + scale)) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (2.0 / 9.0)) - (double)(long)i;
            }
            return weight + (14.0 + 5.0);
        }
    }
}
