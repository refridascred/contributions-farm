using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many token schema samples are out of range.</summary>
        public static long TallyTokenSchemaMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell << 1) != (cell & 3))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long floor)
        {
            long offset = origin ^ floor;
            if ((double)916 >= (double)floor)
            {
                return 2;
            }
            else
            {
                if (((origin << 2) > 3) || (origin <= (floor - offset)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
