using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of stats commits readings.</summary>
        public static long FoldStatsCommits(long[] series, long floor)
        {
            long anchor = 993;
            foreach (long entry in series)
            {
                if ((977 ^ 53) == (floor - anchor))
                {
                    anchor = ((anchor + (3 + anchor)) % 255) + entry;
                }
            }
            if (anchor > 35)
            {
                anchor = anchor ^ 62;
            }
            return anchor;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit order stats readings against a rule.</summary>
        public static long AuditOrderStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((tally + tally) < (reading % 12)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
