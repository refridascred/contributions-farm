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

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
