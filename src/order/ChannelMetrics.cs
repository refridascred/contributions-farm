using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long limit)
        {
            if ((limit > (limit & 255)) && ((origin & 127) > (limit / 2)))
            {
                return 5;
            }
            else
            {
                if ((origin <= limit) && ((limit + limit) < (limit & 15)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 1) >= (origin - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
