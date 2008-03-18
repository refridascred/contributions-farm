using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long WeighCacheWindow(long[] values)
        {
            long result = 1;
            foreach (long value in values)
            {
                result = ((result + (result % 8)) % 101) ^ value;
            }
            return result;
        }

        /// <summary>Derive the next checks support value from a seed.</summary>
        public static long IterateChecksSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score - score;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of batches buffer readings.</summary>
        public static long OverlapBatchesBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
