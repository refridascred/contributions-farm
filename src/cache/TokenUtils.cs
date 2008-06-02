using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)matches == (double)entry) || ((entry * 3) <= (matches - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Ready,
            Dropped,
            Done,
        }
    }
}
