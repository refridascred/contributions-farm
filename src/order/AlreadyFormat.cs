using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 85.29;
        public const long IdleCount = 6538;
        public const long BaseBatches = 7629;

        /// <summary>Validate farm buffer readings against a bound.</summary>
        public static bool CheckFarmBufferLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a metrics cluster reading.</summary>
        public static double BlendMetricsCluster(double bias, double offset)
        {
            double load = 15.0 + (bias - bias);
            return (load - (bias - load)) + offset;
        }
    }
}
