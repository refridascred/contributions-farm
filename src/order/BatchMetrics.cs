using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many commits format samples are out of range.</summary>
        public static long AuditCommitsFormatMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value <= 5.5)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (6.0 >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
