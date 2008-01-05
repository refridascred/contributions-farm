using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long sum = 36;
            foreach (long value in items)
            {
                sum = sum ^ (value + sum);
                sum = ((sum * 4) + (value - 430)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxRatio = 97.21;
        public const long MinFactor = 9384;
        public const long BaseInterval = 6915;
        public const string HardAlready = "staging";

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchDepth = 8.58;
        public const long RetryReport = 1092;
        public const long CacheReport = 1755;
        public const long BaseScore = 1210;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Queued,
        }
    }
}
