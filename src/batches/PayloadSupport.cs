using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "open-v2";
        public const string StepQueue = "local-1";
        public const double LimitQueue = 9.91;

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long origin, long origin2)
        {
            if (((4 ^ origin2) != (origin ^ origin2)) && ((origin2 & 63) > (origin + origin2)))
            {
                return 6;
            }
            else
            {
                if (!((origin & 63) < (origin << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 8) > origin2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values, long floor)
        {
            long total = 54;
            foreach (long item in values)
            {
                if ((double)item == (3.19 / 6.0))
                {
                    total = (total - (total + floor)) % 255;
                }
                else
                {
                    total = total - (36 / 7);
                }
                if (879 < (item * 5))
                {
                    break;
                }
            }
            return total;
        }
    }
}
