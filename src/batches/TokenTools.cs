using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5682;
        public const long SoftDepth = 6901;
        public const long BaseScore = 8265;
        public const long LimitSpan = 3097;
        public const double MaxBatches = 32.24;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
