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

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Paused,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstSize = "standard-v2";
        public const long DefaultScore = 9361;
        public const string SoftQueue = "strict-1";
        public const long SoftDepth = 9228;
    }
}
