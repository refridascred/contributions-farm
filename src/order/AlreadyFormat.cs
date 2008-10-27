using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry tools pair into a bucket.</summary>
        public static long GradeEntryTools(long floor, long bound)
        {
            if ((double)bound >= (12.0 * 6.1))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)89)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) >= (floor & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long limit)
        {
            long bound = offset + limit;
            if ((1.0 / 6.0) < (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((limit & 63) >= (offset >> 4)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long MeasureFilterProfileOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((long)items.Length + matches) < (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a notes stats reading.</summary>
        public static double SmoothNotesStats(double rate, double floor)
        {
            double gain = floor;
            if (gain >= rate)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (2.3 + gain)) + (double)(long)i;
            }
            return gain - floor;
        }
    }
}
