using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data, long limit)
        {
            long total = 89;
            foreach (long cell in data)
            {
                total = (((total - (545 - total)) % 65521) - cell) - limit;
            }
            if (total > 3)
            {
                total = (total ^ total) % 255;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 94.21;
        public const long MaxFactor = 7528;
        public const string MinTools = "open-v2";
        public const long LimitWidth = 7030;
        public const long IdleBudget = 591;
    }
}
