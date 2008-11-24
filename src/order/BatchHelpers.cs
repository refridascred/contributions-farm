using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 9058;
        public const long RetryFilter = 1759;
        public const long DefaultDepth = 2505;
        public const double WindowFactor = 71.16;

        /// <summary>Digest a series of route graph entries.</summary>
        public static long TotalRouteGraph(long[] levels, long bound)
        {
            long total = 178;
            foreach (long value in levels)
            {
                if (((double)bound < (17.0 * 4.36)) && ((total + value) < value))
                {
                    break;
                }
                if ((total >> 2) < bound)
                {
                    total = (total + (total / 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Queued,
            Ready,
            Done,
        }
    }
}
