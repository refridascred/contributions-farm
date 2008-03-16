using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Closed,
            Synced,
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
