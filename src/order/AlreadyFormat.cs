using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 9170;
        public const long IdleDepth = 8798;
        public const long SoftBatch = 4414;
        public const long BurstBatch = 9264;

        /// <summary>Adjust a tools route reading.</summary>
        public static double ProjectToolsRoute(double scale, double bias)
        {
            double scale2 = (double)((-638) + 46);
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)(long)i) + bias;
            }
            return scale2 + (scale2 - scale);
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) != (value % 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item * 4) <= seen) && !((item ^ seen) != (item & 31)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
