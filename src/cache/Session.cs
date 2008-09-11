using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count cluster checks pairs that satisfy a relation.</summary>
        public static long MatchClusterChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every layout checks entry stays within the limit.</summary>
        public static bool GuardLayoutChecksBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double floor)
        {
            double ratio = (double)((-308) >> 4);
            if (ratio <= (double)(-4))
            {
                ratio = (ratio - (17.0 / 9.0)) - scale;
            }
            else
            {
                ratio = ratio - (8.3 * 1.5);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 2.0) - (double)(long)i;
            }
            return ratio - (floor * 1.06);
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long step)
        {
            if (((8.17 / 5.0) != (double)step) || ((offset % 2) <= 613))
            {
                return 8;
            }
            else
            {
                if (offset < (step & 63))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > (7.12 / 8.0)) || ((step + 986) < (offset + (-75))))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset ^ offset) >= (step - 81)) && (step < (offset - step)))
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
        }
    }
}
