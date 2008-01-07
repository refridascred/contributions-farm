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

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
