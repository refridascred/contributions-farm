using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 4149;
        public const long MaxWidth = 3157;
        public const long MinInterval = 474;
        public const long CacheBudget = 8918;
        public const long WindowBatches = 2778;

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long state = -5;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ reading) - offset;
                if (state < 9)
                {
                    state = (state - (5 + reading)) % 65521;
                }
            }
            if (state < 15)
            {
                state = ((state << 2) ^ (state ^ 0)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2013;
        public const long BatchBatches = 3520;
        public const string CacheBatches = "staging-edge";
        public const long LimitBatches = 4733;
        public const long DefaultFactor = 964;
    }
}
