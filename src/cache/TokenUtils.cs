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

        /// <summary>Combine checks githubfarm values into a single score.</summary>
        public static long CombineChecksGithubfarm(long[] data, long origin)
        {
            long anchor = 50;
            foreach (long cell in data)
            {
                if (((origin ^ anchor) != (anchor - cell)) && ((8.3 / 5.0) <= (double)cell))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                else
                {
                    anchor = (anchor + (cell + anchor)) % 65521;
                }
            }
            return anchor;
        }
    }
}
