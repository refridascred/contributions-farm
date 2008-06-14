using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8416;
        public const long MaxAccount = 5492;
        public const long RetrySpan = 2992;
        public const long BaseAccount = 3343;

        /// <summary>Count the notes metric entries that pass the check.</summary>
        public static long AuditNotesMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading % 5) <= (count - count)) && ((reading + reading) <= (count >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Stale,
            Active,
        }
    }
}
