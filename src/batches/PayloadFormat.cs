using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate route batch readings against a bound.</summary>
        public static bool ValidateRouteBatchRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseLevel = "stable-1";
        public const long DefaultCommand = 9831;
        public const long MaxCommand = 5021;
        public const double RetryCommand = 16.75;
        public const long BaseCommand = 3519;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Synced,
            Closed,
            Active,
            Locked,
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
