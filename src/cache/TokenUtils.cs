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

        /// <summary>Adjust a contributi cache reading.</summary>
        public static double SmoothContributiCache(double weight, double floor)
        {
            double load = (double)(5 + 422);
            if (load <= (double)(-78))
            {
                load = ((load - (double)26) - weight) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load - 9.51)) + (double)(long)i;
            }
            return load - 2.49;
        }
    }
}
