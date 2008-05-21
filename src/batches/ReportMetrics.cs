using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command entry samples are out of range.</summary>
        public static long TallyCommandEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < (23 + datum))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Active,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Closed,
            Retry,
            Failed,
        }
    }
}
