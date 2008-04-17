using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double bias)
        {
            double mean = 1.04;
            if (mean >= (mean / 7.0))
            {
                mean = (mean + mean) + ratio;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - mean;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double ratio = (double)(3 - 83);
            if (ratio <= (floor - floor))
            {
                ratio = ratio - (scale * 7.16);
            }
            return ratio + (double)86;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count == (0.41 + 8.87))
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double mean = 17.0;
            if (mean < (floor / 8.0))
            {
                mean = mean + (scale - 2.1);
            }
            else
            {
                mean = mean - (8.96 * 1.0);
            }
            return mean - (scale + floor);
        }
    }
}
