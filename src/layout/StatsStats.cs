using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 5126;
        public const long CacheStream = 1012;
        public const string DefaultStream = "local";
        public const long HardStream = 3981;
        public const long RetrySpan = 6678;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Queued,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstRatio = 2928;
        public const long StepWidth = 8499;
        public const long IdleCommand = 3364;
        public const long BurstCommand = 6869;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
