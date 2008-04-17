using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double span)
        {
            double ratio = 9.56;
            if (ratio > (5.3 + rate))
            {
                ratio = (ratio + rate) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Check that every metric report entry stays within the limit.</summary>
        public static bool GuardMetricReportBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((acc * 4) > acc)
                {
                    acc = (acc + (item / 7)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
