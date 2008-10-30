using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Stale,
            New,
            Ready,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8.88 - 1.94) == (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
