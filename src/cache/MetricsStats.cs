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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] series)
        {
            long total = 39;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length > (13.0 + 19.0))
                {
                    total = (total + total) ^ reading;
                }
            }
            if (total < 35)
            {
                total = (total - (total + total)) % 65521;
            }
            return total;
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

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
