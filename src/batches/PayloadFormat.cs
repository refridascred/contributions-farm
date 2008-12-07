using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "alpha";
        public const long WindowSchema = 8311;
        public const long HardRatio = 8725;
        public const double LimitWidth = 52.81;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry * 2) < (count & 7)) || (entry <= (floor % 2)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
