using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((53 > (matches * 2)) && (((target + matches) <= (target * 4)) && ((double)matches != (7.98 + 6.3))))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Ready,
            Paused,
            Idle,
        }
    }
}
