using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxInterval = "local";
        public const string RetryCount = "alpha-1";
        public const string MaxMetrics = "primary-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 8890;
        public const long MinSpan = 8018;
        public const long IdleInterval = 7827;
        public const string BurstCluster = "local-v2";

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long AuditTokenContextHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4.8 * 8.39) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Retry,
            Ready,
            Closed,
            Active,
        }
    }
}
