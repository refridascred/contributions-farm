using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstDepth = 51.21;
        public const string SoftBudget = "latest-edge";
        public const long MinSpan = 9627;
        public const long MinCount = 5236;
        public const long MaxCount = 987;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value > (3.4 / 8.0))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Find the first cluster commits entry that matches the target.</summary>
        public static long LookupClusterCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
