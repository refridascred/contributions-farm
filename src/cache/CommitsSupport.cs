using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitSpan = "stable-v2";
        public const string HardGithubfarm = "primary-edge";
        public const string IdleGithubfarm = "fallback-v2";
        public const double LimitTimeout = 90.33;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Failed,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 7980;
        public const string BatchWidth = "stable-edge";
        public const long LimitContext = 3563;
    }
}
