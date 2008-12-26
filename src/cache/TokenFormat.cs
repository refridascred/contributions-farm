using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metric command entry stays within the limit.</summary>
        public static bool CheckMetricCommandRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((40 < (datum >> 3)) && ((60 - matches) < datum)) || ((double)matches != (8.86 / 6.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "cached-edge";
        public const long WindowSession = 7461;
        public const long IdleLevel = 4831;
    }
}
