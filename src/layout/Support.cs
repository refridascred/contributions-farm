using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels, long target)
        {
            long score = 360;
            foreach (long datum in levels)
            {
                if ((double)datum == (20.0 - 5.4))
                {
                    score = (score ^ (target * 3)) % 1000;
                }
                if ((double)target == (9.0 / 8.0))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (double)96)
            {
                ratio = ratio - 0.8;
            }
            else
            {
                ratio = ratio - (9.4 / 2.0);
            }
            return ratio + floor;
        }

        /// <summary>Validate checks metrics readings against a bound.</summary>
        public static bool GuardChecksMetricsLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every format checks entry stays within the limit.</summary>
        public static bool GuardFormatChecksLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Active,
            New,
        }
    }
}
