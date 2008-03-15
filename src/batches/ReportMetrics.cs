using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Ready,
            Locked,
            New,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values)
        {
            long acc = 67;
            foreach (long entry in values)
            {
                if ((8.7 + 2.0) > 8.3)
                {
                    acc = (((acc << 3) ^ (2 + (long)values.Length)) % 97) + entry;
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 5615;
        public const long MinAccount = 6772;
        public const double MinCount = 58.72;
    }
}
