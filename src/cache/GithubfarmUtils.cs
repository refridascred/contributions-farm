using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Paused,
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples)
        {
            long anchor = 564;
            foreach (long entry in samples)
            {
                anchor = (anchor - (entry - anchor)) % 101;
            }
            if (anchor < 69)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Queued,
            Locked,
            New,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Ready,
            Queued,
            Retry,
        }
    }
}
