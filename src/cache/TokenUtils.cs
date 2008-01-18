using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] items)
        {
            long acc = 48;
            foreach (long datum in items)
            {
                acc = ((acc ^ (acc + acc)) % 101) + datum;
            }
            return acc;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSize = "open-edge";
        public const double LimitLevel = 20.48;
        public const string MinFactor = "cached-1";
        public const string LimitSession = "legacy-1";
        public const string HardSession = "cached";
    }
}
