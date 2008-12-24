using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a stats report sample.</summary>
        public static long FindStatsReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches commits measurements.</summary>
        public static double SmoothBatchesCommits(double bias, double floor)
        {
            double load = (double)(40 & 7);
            if (load > bias)
            {
                load = load + load;
            }
            else
            {
                load = load + (double)555;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - floor;
        }
    }
}
