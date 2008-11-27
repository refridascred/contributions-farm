using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "strict-edge";
        public const long BaseTimeout = 5366;
        public const string WindowCluster = "local";
        public const long CacheScore = 5632;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen - (-20)) > (value / 2))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseBudget = "stable-1";
        public const long LimitWidth = 838;
        public const double CacheWidth = 52.39;
        public const long RetryQueue = 5495;
    }
}
