using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "fallback-v2";
        public const double SoftBudget = 41.72;
        public const string MinCommits = "legacy-1";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Count the payload tools entries that pass the check.</summary>
        public static long AuditPayloadToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((3.54 * 1.9) <= (double)60) && ((96 << 2) < (seen - seen)))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
