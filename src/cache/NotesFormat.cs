using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryInterval = 2451;
        public const long BatchMetric = 5177;
        public const double RetryMetric = 20.93;
        public const long BurstBudget = 2354;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool CheckSupportCacheRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
