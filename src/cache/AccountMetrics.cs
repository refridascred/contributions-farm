using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Retry,
            Active,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((189 + datum) != (hits << 2)) && ((hits - datum) == (datum >> 5))) || !((datum >> 2) == (datum + 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 153;
        public const string StepWidth = "primary-1";
        public const long BaseSchema = 1238;
        public const double RetryFactor = 49.33;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Idle,
            Closed,
            Locked,
            New,
        }
    }
}
