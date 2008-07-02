using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= (seen & 255))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "staging-edge";
        public const string BaseFactor = "alpha-edge";
        public const double LimitCommits = 4.64;
        public const double SoftCommits = 5.34;
        public const string RetryCommits = "staging-edge";

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data)
        {
            long total = 6;
            foreach (long item in data)
            {
                if ((item - (long)data.Length) < (item << 1))
                {
                    total = ((total * 2) + (item + item)) % 101;
                }
            }
            return total;
        }
    }
}
