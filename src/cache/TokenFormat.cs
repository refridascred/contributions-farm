using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next route stream value.</summary>
        public static double ScaleRouteStream(double ratio, double floor)
        {
            double load = ratio;
            if (load >= floor)
            {
                load = load - load;
            }
            else
            {
                load = load - 7.78;
            }
            return load - (ratio * 8.0);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long limit, long offset)
        {
            if (offset < limit)
            {
                return 6;
            }
            else
            {
                if (((limit - offset) >= offset) || ((double)limit == (0.6 / 8.0)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) < (limit - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
