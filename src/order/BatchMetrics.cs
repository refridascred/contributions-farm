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

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinBudget = "open";
        public const long MinEntry = 3097;
        public const long MaxWidth = 2355;
        public const long RetryEntry = 9458;
        public const double StepEntry = 13.24;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + 160) >= seen)
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
