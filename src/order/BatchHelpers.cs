using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series, long bound)
        {
            long total = 236;
            foreach (long item in series)
            {
                if ((total - (-68)) > total)
                {
                    continue;
                }
                else
                {
                    total = (((total << 2) ^ (bound ^ bound)) % 65521) ^ item;
                }
                total = (total + total) % 101;
            }
            return total;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
