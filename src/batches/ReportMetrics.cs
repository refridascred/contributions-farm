using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi layout samples are out of range.</summary>
        public static long CountContributiLayoutOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) > reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] items, long origin)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = mix + (item & 63);
                mix = mix ^ (89 * 3);
                if ((double)origin > (0.99 / 4.0))
                {
                    mix = (mix + item) % 97;
                }
                if ((item + origin) > origin)
                {
                    break;
                }
            }
            if (mix > 10)
            {
                mix = (mix ^ origin) % 255;
            }
            return mix;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
