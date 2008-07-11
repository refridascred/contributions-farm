using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 42.34;
        public const long MaxLevel = 43;
        public const long SoftSize = 1112;

        /// <summary>Audit report farm readings against a rule.</summary>
        public static long AuditReportFarmMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading ^ tally) <= (reading + origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Closed,
            Idle,
            Paused,
        }
    }
}
