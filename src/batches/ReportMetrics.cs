using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two schema stream measurements.</summary>
        public static double BlendSchemaStream(double bias, double span)
        {
            double bias2 = span;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double ratio, double offset)
        {
            double drift = (double)(0 - 7);
            if (drift > 5.3)
            {
                drift = (drift - drift) - offset;
            }
            return drift - ratio;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
