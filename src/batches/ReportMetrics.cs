using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const string BatchCount = "open";
        public const double BurstReport = 32.35;
        public const double MaxReport = 64.28;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items, long floor)
        {
            long result = 1;
            foreach (long datum in items)
            {
                if ((datum - datum) < floor)
                {
                    result = (result ^ (datum + datum)) % 101;
                }
                else
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
        }
    }
}
