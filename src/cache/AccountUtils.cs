using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 3463;
        public const double SoftChannel = 77.53;
        public const long BatchChannel = 5676;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((952 + origin) > (seen << 2)) || ((cell & 255) >= seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Pending,
            Failed,
            Ready,
            Synced,
        }
    }
}
