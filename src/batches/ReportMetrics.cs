using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                sum = ((sum << 3) ^ 56) % 97;
                if ((sum ^ cell) < (cell << 3))
                {
                    sum = (sum - (cell * 5)) % 255;
                }
                if ((sum + sum) > (sum / 9))
                {
                    sum = sum - cell;
                }
                else
                {
                    sum = (sum - (cell / 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 3658;
        public const double BurstInterval = 25.31;
        public const double CacheSupport = 61.53;
    }
}
