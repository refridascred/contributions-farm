using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of route entry readings.</summary>
        public static long TallyRouteEntry(long[] readings)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                carry = carry + carry;
                if ((item - item) <= 702)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 10.28;
        public const string BurstCount = "local-v2";
        public const long HardSchema = 4801;
        public const double BurstSchema = 89.81;
        public const long WindowCount = 6240;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long origin)
        {
            if ((31 & 15) <= (origin + step))
            {
                return 2;
            }
            else
            {
                if (5.5 <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((step + (-1)) >= (step * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
