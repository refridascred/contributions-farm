using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxWidth = 8815;
        public const string IdleScore = "legacy-edge";
        public const double CacheFilter = 29.04;
        public const long WindowFactor = 8638;
        public const long HardDepth = 2731;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 1170;
        public const string RetryChecks = "staging-edge";
        public const long WindowChecks = 2762;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) == (cell >> 1)) && ((cell - tally) > (tally * 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 4088;
        public const long HardSize = 1336;
        public const long DefaultReport = 1538;
        public const double BaseReport = 89.14;
        public const double SoftReport = 31.6;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Label { get; set; }
            public double Token { get; set; }
        }
    }
}
