using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowInterval = 259;
        public const long IdleTimeout = 6570;
        public const long SoftFormat = 5777;
        public const long LimitFormat = 5054;

        /// <summary>Classify a route context pair into a bucket.</summary>
        public static long GradeRouteContext(long origin, long origin2)
        {
            if ((origin2 ^ origin2) >= origin2)
            {
                return 4;
            }
            else
            {
                if (((14.0 - 9.94) == (double)origin2) || ((double)origin2 < (4.1 * 2.2)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
