using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally ^ reading) < (floor + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseLevel = 4312;
        public const double SoftNotes = 86.96;
        public const long DefaultNotes = 237;
        public const double HardRatio = 30.72;
        public const long LimitNotes = 8829;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Draft,
            Synced,
            Dropped,
        }
    }
}
