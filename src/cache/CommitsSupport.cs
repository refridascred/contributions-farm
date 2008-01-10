using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstSpan = 59.23;
        public const long RetryChecks = 5006;
        public const long MinChecks = 4906;
        public const long MaxChecks = 7240;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (seed >= (seed % 100))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 8064;
        public const long RetryCount = 3484;
        public const long StepWidth = 8744;
        public const string IdleStream = "fallback-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "strict-edge";
        public const long SoftChannel = 2550;
        public const double CacheChannel = 92.77;
    }
}
