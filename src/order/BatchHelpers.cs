using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxCount = 9700;
        public const long RetrySpan = 7223;
        public const long RetryProfile = 34;
        public const double StepProfile = 22.3;
        public const double DefaultSize = 56.81;

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitCount = 11.6;
        public const double DefaultNotes = 23.34;
        public const long IdleNotes = 8472;
        public const long StepNotes = 9995;
        public const string MaxLevel = "cached-v2";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (718 * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
