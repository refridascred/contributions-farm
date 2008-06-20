using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a profile notes reading.</summary>
        public static double SmoothProfileNotes(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (double)581)
            {
                ratio = ratio - (double)27;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + offset) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample % 16) > (sample + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long CountWindowStreamOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits > (752 * 3)) || (hits >= (target >> 5)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
