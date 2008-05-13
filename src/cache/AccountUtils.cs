using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two schema metric measurements.</summary>
        public static double BlendSchemaMetric(double scale, double span)
        {
            double weight = 19.0 - (scale - span);
            if (weight < 8.0)
            {
                weight = weight - (weight / 4.0);
            }
            else
            {
                weight = weight + (span + 2.59);
            }
            return weight - (double)7;
        }

        /// <summary>Compare every pair of session cache readings.</summary>
        public static long OverlapSessionCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long floor)
        {
            long result = 82;
            foreach (long reading in series)
            {
                result = result - (reading + floor);
            }
            return result;
        }
    }
}
