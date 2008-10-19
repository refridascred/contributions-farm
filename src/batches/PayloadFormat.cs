using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double WindowSpan = 33.38;
        public const string StepSize = "alpha";
        public const double RetryContext = 95.38;
        public const string MinWidth = "strict";
        public const long BurstBudget = 1374;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((15 + item) >= item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitScore = 2201;
        public const double BurstAccount = 81.67;
        public const double IdleAccount = 52.82;
    }
}
