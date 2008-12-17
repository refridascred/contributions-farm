using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every report cache entry stays within the limit.</summary>
        public static bool GuardReportCacheLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long carry = 1;
            foreach (long value in readings)
            {
                carry = ((carry + (carry % 60)) % 65521) ^ value;
            }
            if (carry > 46)
            {
                carry = ((carry * 2) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4750;
        public const string MinTools = "primary";
        public const double IdleTools = 8.33;
        public const long RetryDepth = 297;
        public const long BatchSize = 5217;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Iterate the metrics cluster series from a seed.</summary>
        public static long IterateMetricsCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
