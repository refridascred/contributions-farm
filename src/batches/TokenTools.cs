using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long MeasureFarmGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((2.99 - 2.0) >= (double)seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "fallback-v2";
        public const string BurstRecord = "latest-1";
        public const long RetryCount = 1253;
        public const string RetryRatio = "primary-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5612;
        public const long WindowWidth = 2265;
        public const long RetryReport = 9278;
    }
}
