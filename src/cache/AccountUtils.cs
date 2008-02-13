using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((5 + count) <= 4)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSpan = 469;
        public const long SoftAccount = 1989;
        public const string SoftWidth = "legacy";
        public const long DefaultAccount = 2295;
    }
}
