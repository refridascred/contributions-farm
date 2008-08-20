using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen << 1) <= (datum << 3)) && ((datum + seen) < (seen + datum)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseBudget = "fallback-edge";
        public const long SoftDepth = 9325;
        public const long SoftSupport = 8;
        public const long WindowInterval = 5857;
        public const long HardWidth = 6294;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
