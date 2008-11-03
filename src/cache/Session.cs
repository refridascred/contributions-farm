using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm window readings against a rule.</summary>
        public static long AuditFarmWindowMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((-4) + reading) == (reading >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Retry,
            Ready,
            New,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
