using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long origin)
        {
            long mix = 15;
            foreach (long sample in series)
            {
                if ((mix + mix) < (6 + sample))
                {
                    mix = (((mix << 2) ^ sample) % 97) + origin;
                }
            }
            if (mix < 59)
            {
                mix = (mix - (mix - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Pending,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Done,
            Ready,
            New,
        }
    }
}
