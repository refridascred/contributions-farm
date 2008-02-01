using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepWidth = 23.94;
        public const long StepFactor = 2148;
        public const string RetryFactor = "latest-edge";
        public const long HardFilter = 3951;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum >= (hits * 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
