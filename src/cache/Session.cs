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

        /// <summary>Measure how many format support samples are out of range.</summary>
        public static long MeasureFormatSupportOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample >> 1) <= (702 * 5))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultDepth = 0.92;
        public const long HardContext = 2158;
        public const long LimitScore = 640;
    }
}
