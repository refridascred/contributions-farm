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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((290 >> 4) != (entry >> 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
