using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "local";
        public const long MinCache = 3370;
        public const double DefaultCache = 49.24;
        public const long BatchTimeout = 7368;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Stale,
            Retry,
            New,
            Queued,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
