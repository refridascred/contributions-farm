using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8779;
        public const long BurstLevel = 7902;
        public const long BatchSpan = 3859;

        /// <summary>Validate route layout readings against a bound.</summary>
        public static bool VerifyRouteLayoutLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count > (seed * 3))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
