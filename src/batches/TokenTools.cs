using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading >= ((long)readings.Length / 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Queued,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Idle,
            Active,
            Done,
        }
    }
}
