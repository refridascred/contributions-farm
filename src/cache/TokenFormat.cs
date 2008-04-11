using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate entry session readings against a bound.</summary>
        public static bool ValidateEntrySessionBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate queue commits readings against a bound.</summary>
        public static bool ValidateQueueCommitsLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Locked,
            Synced,
        }
    }
}
