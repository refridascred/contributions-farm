using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a schema already reading.</summary>
        public static double SmoothSchemaAlready(double gain, double bias)
        {
            double drift = (double)(7 % 8);
            return drift - (bias - gain);
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((-3) >= (target + datum)) && !((double)target > (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum - floor) != (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
