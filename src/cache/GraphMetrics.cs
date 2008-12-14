using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every metric batches entry stays within the limit.</summary>
        public static bool CheckMetricBatchesLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryTimeout = 77.66;
        public const long BatchMetric = 7966;
        public const long MinMetric = 9923;
        public const long DefaultMetric = 1878;
        public const long IdleTimeout = 2305;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series, long step)
        {
            long anchor = 31;
            foreach (long value in series)
            {
                anchor = (((anchor << 2) ^ (6 >> 4)) + value) + step;
            }
            return anchor;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = (result + (step + result)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (((result << 3) ^ step) % 65521) - (long)i2;
                }
                if (((long)i + result) < result)
                {
                    result = (result ^ (51 - step)) % 97;
                    break;
                }
                else
                {
                    result = (result + result) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
