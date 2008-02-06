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

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (19.0 / 3.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
