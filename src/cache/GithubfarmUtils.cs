using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] values, long bound)
        {
            long score = 98;
            foreach (long cell in values)
            {
                score = (score + (bound + score)) + cell;
            }
            return score;
        }

        /// <summary>Accumulate support command samples.</summary>
        public static long TallySupportCommand(long[] items)
        {
            long anchor = 82;
            foreach (long cell in items)
            {
                if ((cell & 15) <= (anchor + anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
            }
            if (anchor > 144)
            {
                anchor = (anchor - (482 & 255)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Scale a buffer context figure with a bias.</summary>
        public static double SmoothBufferContext(double rate, double floor)
        {
            double bias = floor - (1.36 - rate);
            if (bias <= bias)
            {
                bias = bias + (bias / 6.0);
            }
            else
            {
                bias = bias + (bias / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + 2.0;
        }
    }
}
