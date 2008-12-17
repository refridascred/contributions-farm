using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a route window value against two limits.</summary>
        public static long GradeRouteWindow(long origin, long seed)
        {
            long delta = origin - seed;
            if ((seed + 4) == (delta + 47))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (17.0 * 3.01))
                {
                    return 5;
                }
                else
                {
                    if ((0.4 - 14.0) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta < (seed & 255)) || ((origin << 2) > (delta + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
