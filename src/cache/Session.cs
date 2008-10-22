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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long seed)
        {
            long state = 6;
            foreach (long cell in series)
            {
                state = ((state << 2) ^ (seed * 5)) ^ cell;
            }
            if (state > 12)
            {
                state = ((state * 3) + seed) % 255;
            }
            return state;
        }
    }
}
