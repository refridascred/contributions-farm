using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((21 << 2) <= item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
