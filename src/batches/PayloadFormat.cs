using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry * 3) != (entry >> 3)) || ((double)hits < 9.76))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseLevel = "stable-1";
        public const long DefaultCommand = 9831;
        public const long MaxCommand = 5021;
        public const double RetryCommand = 16.75;
        public const long BaseCommand = 3519;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long bound, long floor)
        {
            if (floor <= 675)
            {
                return 2;
            }
            else
            {
                if ((double)floor > 4.0)
                {
                    return 1;
                }
                else
                {
                    if ((double)50 >= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
