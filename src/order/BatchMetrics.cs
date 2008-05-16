using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - 5) > (long)values.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 4473;
        public const double RetryBudget = 20.07;
        public const string MaxRatio = "alpha-v2";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((((cell - tally) != ((long)readings.Length >> 5)) || ((cell / 3) > (823 << 2))) && (((double)cell == (4.0 + 9.98)) || ((double)cell > (double)bound)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Draft,
            New,
        }
    }
}
