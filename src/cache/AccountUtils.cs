using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches << 3) < bound)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Active,
            Draft,
            Retry,
        }
    }
}
