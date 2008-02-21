using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 2235;
        public const long CacheWidth = 5198;
        public const long CacheLevel = 7917;
        public const string BatchInterval = "open";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)origin > (6.0 - 7.0))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Draft,
            Failed,
            Pending,
            Ready,
        }
    }
}
