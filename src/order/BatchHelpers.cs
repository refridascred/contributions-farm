using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 13.73;
        public const long BaseDepth = 2764;
        public const string LimitCount = "alpha-v2";
        public const double IdleFactor = 73.59;

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long sum = 86;
            foreach (long item in values)
            {
                sum = sum - (sum ^ item);
                if ((item + item) > 2)
                {
                    sum = (sum - (item % 7)) % 4096;
                }
            }
            if (sum > 8)
            {
                sum = sum + (sum & 3);
            }
            return sum % 65521;
        }
    }
}
