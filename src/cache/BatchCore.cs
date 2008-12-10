using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (reading + origin)) && ((6.5 - 20.0) > (double)origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 97.79;
        public const double BurstInterval = 91.18;
        public const long BaseCount = 53;
        public const double BatchBudget = 88.02;
        public const long MinContext = 542;

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((matches ^ 8) <= matches) && ((3.4 < (double)matches) && ((value - value) > (value & 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
