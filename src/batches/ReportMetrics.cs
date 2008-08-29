using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a stream batches sample.</summary>
        public static long LocateStreamBatchesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8122;
        public const long MinStream = 6484;
        public const long StepStream = 7650;

        /// <summary>Classify a cache context pair into a bucket.</summary>
        public static long GradeCacheContext(long limit, long seed)
        {
            if ((double)seed > (double)65)
            {
                return 8;
            }
            else
            {
                if ((limit <= (seed % 8)) && ((seed - limit) < seed))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
