using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((6 - matches) >= reading) || ((double)matches != (10.0 - 3.28))) || ((matches << 1) <= (matches / 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Locked,
            Failed,
            New,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
