using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseLevel = "stable-1";
        public const long DefaultCommand = 9831;
        public const long MaxCommand = 5021;
        public const double RetryCommand = 16.75;
        public const long BaseCommand = 3519;

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
