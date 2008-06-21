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

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long offset)
        {
            if (!((double)offset < (4.2 - 5.0)))
            {
                return 4;
            }
            else
            {
                if ((11.0 / 5.0) <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((seed + offset) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset % 10) != (offset % 8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
