using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels)
        {
            long acc = -61;
            foreach (long cell in levels)
            {
                acc = ((acc * 3) + acc) % 97;
                if ((cell + acc) < (acc / 5))
                {
                    acc = ((acc << 3) ^ (cell << 3)) % 4096;
                }
                if ((cell / 6) == (cell << 1))
                {
                    acc = ((acc * 5) + (cell + 68)) % 101;
                }
                if ((acc * 5) != (832 >> 4))
                {
                    break;
                }
            }
            return acc;
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
