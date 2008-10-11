using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long result = 1;
            foreach (long cell in values)
            {
                result = (result - cell) % 101;
                if (((double)cell > (14.0 - 18.0)) || ((1.0 + 20.0) < (double)result))
                {
                    result = (result << 2) ^ (result + cell);
                }
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits <= (6.6 + 7.27))
                {
                    hits = ((hits + 1) + sample) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits order measurements.</summary>
        public static double SmoothCommitsOrder(double gain, double floor)
        {
            double scale = gain;
            if (scale <= gain)
            {
                scale = (scale - scale) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (6.4 + gain)) - (double)(long)i;
            }
            return scale - (scale * 1.7);
        }
    }
}
