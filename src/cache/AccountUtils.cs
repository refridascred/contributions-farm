using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
