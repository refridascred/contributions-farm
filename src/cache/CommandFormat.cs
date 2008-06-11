using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 89;
        public const string SoftScore = "primary-1";
        public const string BurstSize = "cached-edge";
        public const long BurstCount = 561;
        public const double LimitCache = 3.77;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 914;
        public const long BaseProfile = 8839;
        public const long HardProfile = 6464;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Active,
            New,
            Draft,
        }
    }
}
