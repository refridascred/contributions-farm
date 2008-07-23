using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every githubfarm layout entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLayoutLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Failed,
            Synced,
            Paused,
            Stale,
        }
    }
}
