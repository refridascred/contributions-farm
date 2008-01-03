using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long CountContributiFormatMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (5.73 + 7.8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 8155;
        public const long LimitScore = 401;
        public const long StepScore = 7374;
        public const string LimitRecord = "open-1";
    }
}
