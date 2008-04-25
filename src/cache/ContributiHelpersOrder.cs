using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 7.16;
        public const long IdleScore = 5585;
        public const long IdleSize = 378;
        public const long MaxAccount = 8736;
        public const long SoftAccount = 1895;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((sample << 2) > (sample >> 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
