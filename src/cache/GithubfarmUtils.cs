using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 91.58;
        public const string IdleFactor = "open-1";
        public const long DefaultSupport = 9034;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Pending,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
