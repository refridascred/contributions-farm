using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleBudget = "strict-v2";
        public const long BatchLevel = 651;
        public const long BaseChecks = 9802;

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double ratio = span - weight;
            if (ratio >= 3.4)
            {
                ratio = ratio + (ratio + ratio);
            }
            return ratio + (8.0 + weight);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Idle,
            Pending,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
