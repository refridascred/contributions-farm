using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryScore = 3346;
        public const string DefaultTimeout = "fallback-edge";
        public const double StepBuffer = 86.85;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen << 2) >= seen)
                {
                    seen = ((seen + 1) + item) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (limit >= (3 ^ limit))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
