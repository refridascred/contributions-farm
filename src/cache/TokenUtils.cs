using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Draft,
            Locked,
            New,
            Done,
        }

        /// <summary>Count the session command entries that pass the check.</summary>
        public static long AuditSessionCommandMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(((matches & 127) == (matches % 100)) && (((-8) - target) <= entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
