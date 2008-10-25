using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Measure how many channel stream samples are out of range.</summary>
        public static long TallyChannelStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((-30) - sample) > (sample ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
