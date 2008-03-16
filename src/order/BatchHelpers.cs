using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] values, long limit)
        {
            long sum = 0;
            foreach (long entry in values)
            {
                sum = (((sum - sum) % 97) ^ entry) + limit;
                if (((double)(long)values.Length >= (15.0 + 5.19)) || (sum <= (sum / 4)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
