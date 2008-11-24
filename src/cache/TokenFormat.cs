using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(7.0 <= (double)cell) && !(cell <= (seen + cell)))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Queued,
            Draft,
        }
    }
}
