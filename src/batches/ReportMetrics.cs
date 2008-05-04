using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 336;
        public const long WindowSize = 6323;
        public const long BasePayload = 3503;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((value - (-6)) >= value) || (value < (602 & 63))) && (((tally - tally) >= (5 + value)) && ((value * 3) <= value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count << 2) >= count) && ((item % 16) > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
