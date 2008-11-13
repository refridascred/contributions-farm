using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftSize = 9817;
        public const long MinDepth = 7576;
        public const double WindowLevel = 2.6;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 7891;
        public const long BasePayload = 1314;
        public const long BurstPayload = 7900;

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryTimeout = "latest";
        public const long BaseGraph = 6031;
        public const double SoftFactor = 56.96;
        public const long BaseFactor = 8796;
        public const long RetryGraph = 6934;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell == (6.41 + 1.9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
