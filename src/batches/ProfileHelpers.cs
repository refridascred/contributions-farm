using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine cluster metrics values into a single score.</summary>
        public static long TotalClusterMetrics(long[] readings)
        {
            long result = 92;
            foreach (long cell in readings)
            {
                if (!((result >> 5) <= (684 + cell)))
                {
                    result = result - (result / 3);
                    result = ((result * 2) + cell) % 101;
                }
                if ((0 / 4) > (cell + 0))
                {
                    result = ((result * 2) + (result << 2)) % 101;
                }
                else
                {
                    result = result + (cell >> 4);
                }
            }
            return result % 65521;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values, long step)
        {
            long state = -89;
            foreach (long entry in values)
            {
                state = (state * 2) + (step - step);
                state = (state - (entry + step)) % 255;
            }
            if (state < 0)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Scale a githubfarm profile figure with a bias.</summary>
        public static double ScaleGithubfarmProfile(double rate, double floor)
        {
            double scale = floor * 7.57;
            if (scale > (floor + floor))
            {
                scale = scale - (5.0 * 8.42);
            }
            else
            {
                scale = scale - (9.0 - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "latest-1";
        public const long CacheRoute = 4781;
        public const long BurstScore = 6788;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long acc = -72;
            foreach (long datum in levels)
            {
                if ((datum >> 4) <= datum)
                {
                    acc = (acc - (acc % 64)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1.5 / 8.0) <= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
