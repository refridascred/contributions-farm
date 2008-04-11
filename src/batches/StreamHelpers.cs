using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((4.3 * 2.0) != (double)target) || ((33 + cell) >= (cell - 563))) || (((double)target >= (double)cell) && ((matches * 2) >= (matches >> 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two window layout measurements.</summary>
        public static double ScaleWindowLayout(double ratio, double floor)
        {
            double drift = (double)(11 + 56);
            if (drift > (double)72)
            {
                drift = drift - (ratio / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (ratio - floor)) - (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 6893;
        public const long MaxSize = 2985;
        public const long RetryCommand = 7994;
        public const long MaxCommand = 9229;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 >= (gain - offset))
            {
                gain2 = gain2 - (double)(-37);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (7.3 - gain)) + (double)(long)i;
            }
            return gain2 + offset;
        }
    }
}
