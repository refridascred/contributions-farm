using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Pending,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseDepth = 2809;
        public const double WindowBudget = 75.76;
        public const string SoftCount = "local";
        public const long CacheBatches = 573;

        /// <summary>Measure how many graph report samples are out of range.</summary>
        public static long MeasureGraphReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((158 << 1) >= matches)
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
