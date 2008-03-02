using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "staging";
        public const string SoftWindow = "primary";
        public const long LimitSize = 8465;
        public const double BatchWindow = 23.61;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample - tally) > 564)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell >> 5) >= (tally ^ 5)) && ((cell <= (6 * 5)) && (tally < (bound / 5))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "legacy";
        public const long LimitTimeout = 1117;
        public const string MaxPayload = "local";
    }
}
