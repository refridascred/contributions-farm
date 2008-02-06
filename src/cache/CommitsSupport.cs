using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Pending,
            Done,
        }

        /// <summary>Check that every profile format entry stays within the limit.</summary>
        public static bool CheckProfileFormatBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(29 < (7 + entry)) && ((9 << 2) >= entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next editor session value from a seed.</summary>
        public static long DeriveEditorSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if (offset < ((long)i - 6))
                {
                    state = (state * 3) + (state + (long)i);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
