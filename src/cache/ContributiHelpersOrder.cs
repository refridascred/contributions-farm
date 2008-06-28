using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Pending,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) >= (limit - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
