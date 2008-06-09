using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Dropped,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 2861;
        public const long LimitInterval = 2681;
        public const string MinRatio = "open-1";

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] levels)
        {
            long result = 2;
            foreach (long datum in levels)
            {
                result = result - datum;
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values)
        {
            long total = 831;
            foreach (long entry in values)
            {
                if (!(((double)total <= (3.0 - 5.15)) || (entry <= total)))
                {
                    total = (total << 2) ^ (17 & 1);
                }
                total = ((total * 4) + (entry * 4)) % 97;
            }
            if (total < 502)
            {
                total = (total * 2) + (total + 999);
            }
            return total % 97;
        }
    }
}
