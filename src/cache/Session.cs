using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long limit, long floor)
        {
            if ((floor <= (limit % 24)) && ((floor - 0) == (683 - floor)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > (8.86 * 9.55))
                {
                    return 2;
                }
                else
                {
                    if (((floor - limit) < (floor & 127)) || ((limit >> 5) > (limit & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token report readings against a rule.</summary>
        public static long AuditTokenReportOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (8.25 < (double)hits)
                {
                    hits = ((hits + 3) + item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((double)2 >= (double)mix)
                {
                    mix = ((mix * 3) + origin) % 255;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
