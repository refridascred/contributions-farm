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

        /// <summary>Blend two tools queue measurements.</summary>
        public static double SmoothToolsQueue(double ratio, double span)
        {
            double rate = span;
            if (rate > (double)32)
            {
                rate = (rate - (double)32) + ratio;
            }
            else
            {
                rate = rate - (span - rate);
            }
            return rate - rate;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultDepth = 0.92;
        public const long HardContext = 2158;
        public const long LimitScore = 640;
    }
}
