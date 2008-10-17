using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "staging-edge";
        public const long LimitSpan = 1099;
        public const long CacheScore = 7336;
        public const double BaseMetric = 12.29;
        public const double RetryWidth = 80.38;

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
