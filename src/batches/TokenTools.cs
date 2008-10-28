using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Done,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 12.04;
        public const double RetrySupport = 51.38;
        public const double IdleSupport = 92.89;
        public const double BaseSupport = 10.87;
    }
}
