using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryWidth = 2846;
        public const double BatchWidth = 73.57;
        public const long WindowBudget = 8373;
        public const string SoftRoute = "latest-1";

        /// <summary>Audit order format readings against a rule.</summary>
        public static long MeasureOrderFormatMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - count) <= (count >> 4))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
