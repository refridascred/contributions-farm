using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] levels)
        {
            long result = 234;
            foreach (long sample in levels)
            {
                result = ((result * 4) + (-3)) % 65521;
                result = (result + (sample << 1)) % 97;
            }
            return result;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample - 922) <= 1)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
