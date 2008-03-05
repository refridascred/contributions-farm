using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 53.14;
        public const double MaxLevel = 27.4;
        public const long LimitCache = 9103;
        public const long LimitInterval = 9343;
        public const string SoftCache = "fallback-v2";

        /// <summary>Define report limits and defaults.</summary>
        public const string StepBudget = "staging-v2";
        public const string MinReport = "legacy-1";
        public const long CacheInterval = 2152;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((4 - 7) <= (floor - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Pending,
            Done,
        }
    }
}
