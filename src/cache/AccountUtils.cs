using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count << 1) <= (86 + step)) && (count < (count / 6)))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 8077;
        public const long SoftSize = 158;
        public const long CacheContext = 84;
    }
}
