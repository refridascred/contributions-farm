using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Synced,
            Active,
            Queued,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "fallback-v2";
        public const string BurstRecord = "latest-1";
        public const long RetryCount = 1253;
        public const string RetryRatio = "primary-edge";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((348 - 51) > (target ^ target))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
