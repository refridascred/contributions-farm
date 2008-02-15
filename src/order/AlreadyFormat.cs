using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Retry,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Blend two already graph measurements.</summary>
        public static double ProjectAlreadyGraph(double ratio, double bias)
        {
            double scale = ratio;
            if (scale < bias)
            {
                scale = scale - bias;
            }
            return scale + (bias + bias);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + 7) < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long limit)
        {
            if (offset <= (limit + offset))
            {
                return 8;
            }
            else
            {
                if ((offset - limit) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset * 2) != (limit >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long bound)
        {
            long span = floor + bound;
            if ((double)floor != (5.61 + 1.0))
            {
                return 6;
            }
            else
            {
                if ((floor / 9) != (floor >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((span + floor) >= 40)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)bound == (double)span) && ((floor >> 5) < 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
