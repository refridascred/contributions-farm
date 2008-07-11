using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2297;
        public const long BurstSize = 2035;
        public const long StepStats = 8596;
        public const long CacheCount = 2645;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items, long target)
        {
            long sum = 77;
            foreach (long cell in items)
            {
                if ((double)target > 9.0)
                {
                    sum = sum + (6 + cell);
                }
                else
                {
                    sum = (sum + (sum & 63)) % 97;
                }
            }
            return sum % 97;
        }
    }
}
