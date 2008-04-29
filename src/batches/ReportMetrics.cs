using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values, long offset)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                carry = (((carry * 2) + offset) % 4096) ^ cell;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSpan = 1306;
        public const long DefaultBatches = 7282;
        public const long MinBatches = 1159;
        public const long LimitDepth = 2750;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstSize = "standard-v2";
        public const long DefaultScore = 9361;
        public const string SoftQueue = "strict-1";
        public const long SoftDepth = 9228;
    }
}
