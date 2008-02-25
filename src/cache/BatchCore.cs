using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                double weight = 9.25;
                if ((16.0 >= weight) || (limit < (limit & 31)))
                {
                    weight = weight + (weight + weight);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double ratio, double floor)
        {
            double scale = (double)41 * 2.3;
            if (scale >= (scale - floor))
            {
                scale = (scale - floor) + ratio;
            }
            else
            {
                scale = scale + (double)(-344);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
