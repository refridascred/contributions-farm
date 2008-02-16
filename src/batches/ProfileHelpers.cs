using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long MeasureWindowLayoutOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen < (offset & 63)) && ((596 / 6) != (sample & 1)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph route value.</summary>
        public static double BlendGraphRoute(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= mean)
            {
                mean = mean + ratio;
            }
            else
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean + 5.1)) - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total - step) - datum;
            }
            if (total < 116)
            {
                total = total + (806 + step);
            }
            return total;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 1715;
        public const long SoftContext = 1923;
        public const long BaseContext = 8429;
        public const long RetryLevel = 3051;
        public const string CacheContext = "strict-v2";
    }
}
