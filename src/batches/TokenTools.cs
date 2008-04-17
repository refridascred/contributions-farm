using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 5699;
        public const double HardChecks = 16.37;
        public const long MaxSize = 3970;
        public const long MinCount = 308;
        public const string WindowCount = "latest-v2";

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Idle,
            Closed,
        }
    }
}
