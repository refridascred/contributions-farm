using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate support route readings against a bound.</summary>
        public static bool CheckSupportRouteBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Idle,
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchWidth = 19.23;
        public const long WindowSpan = 229;
        public const long WindowDepth = 4854;
    }
}
