using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long AuditMetricsBufferMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((-578) + floor) < floor)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBudget = 4947;
        public const double MaxSpan = 6.61;
        public const string MaxDepth = "primary-1";
        public const string BatchBudget = "strict-v2";
        public const long RetryBuffer = 9681;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Offset { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
