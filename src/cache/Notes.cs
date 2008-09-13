using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((4.0 / 9.0) > (double)bound)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheInterval = 27.9;
        public const long BurstContext = 8404;
        public const long HardContext = 7869;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
