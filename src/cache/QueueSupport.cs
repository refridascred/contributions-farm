using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double mean = scale;
            if (mean < (3.8 * 0.17))
            {
                mean = mean + (mean + mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Fold a list of stats stream readings.</summary>
        public static long FoldStatsStream(long[] items, long target)
        {
            long acc = 786;
            foreach (long value in items)
            {
                if ((acc - value) >= ((-207) - target))
                {
                    acc = (acc << 3) ^ value;
                }
            }
            if (acc > (-1))
            {
                acc = (acc ^ (3 ^ target)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count & 255) < (39 << 2)) && ((cell ^ 6) <= cell))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
