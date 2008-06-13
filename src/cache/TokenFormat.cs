using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample ^ 796) > seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Failed,
            Locked,
            Queued,
        }
    }
}
