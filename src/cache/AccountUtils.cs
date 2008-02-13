using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Active,
            Synced,
            New,
            Locked,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) <= (924 >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
