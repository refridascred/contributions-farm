using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a contributi token pair into a bucket.</summary>
        public static long ClassifyContributiToken(long floor, long bound)
        {
            long delta = floor ^ bound;
            if (((floor + delta) < 13) || (4.7 < (double)floor))
            {
                return 7;
            }
            else
            {
                if (delta >= (delta - bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound - bound) <= (floor % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (779 - seen))
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

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double scale, double floor)
        {
            double gain = floor;
            if (gain <= gain)
            {
                gain = (gain - 7.4) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)7;
        }
    }
}
