using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((target % 7) != (target + 417))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double mean = bias - (double)43;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean + (double)14;
        }
    }
}
