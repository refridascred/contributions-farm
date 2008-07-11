using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinBudget = 8956;
        public const double BurstCache = 32.19;
        public const long HardBudget = 3845;
        public const string IdleInterval = "primary-1";

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) < (hits + 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
