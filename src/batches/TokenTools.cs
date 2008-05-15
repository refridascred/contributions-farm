using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit metric already readings against a rule.</summary>
        public static long CountMetricAlreadyOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value <= (seen >> 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
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
