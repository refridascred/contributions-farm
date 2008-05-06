using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (20.0 + scale)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 7114;
        public const long WindowSpan = 1691;
        public const double IdleDepth = 7.44;
        public const long CacheInterval = 5045;
        public const string RetryQueue = "standard";

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long target)
        {
            if (target <= (9 * 3))
            {
                return 6;
            }
            else
            {
                if ((2.4 / 5.0) == (double)target)
                {
                    return 7;
                }
                else
                {
                    if (offset > target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((30 % 7) < (target ^ 50))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
