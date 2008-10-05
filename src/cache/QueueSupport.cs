using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((1.1 + 1.5) != (double)item) && ((count > 7) && ((double)count > (10.0 / 8.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((0 * 5) != (datum & 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 > gain2)
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (gain2 * 12.0);
        }
    }
}
