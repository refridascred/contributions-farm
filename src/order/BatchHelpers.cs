using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long result = 943;
            foreach (long cell in levels)
            {
                result = result - (cell - result);
                result = (result - cell) % 4096;
            }
            return result;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double bias, double offset)
        {
            double gain = (double)64;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - offset) - (double)(long)i) + bias;
            }
            return gain + gain;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
