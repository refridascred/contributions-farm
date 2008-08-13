using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 64.24;
        public const long BaseCache = 7965;
        public const string LimitCache = "staging-v2";
        public const double IdleTimeout = 87.57;
        public const double LimitSize = 74.11;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ entry) % 101;
                if (entry >= 30)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
