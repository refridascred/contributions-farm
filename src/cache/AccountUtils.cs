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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
