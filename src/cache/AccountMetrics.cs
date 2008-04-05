using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "legacy-edge";
        public const string SoftRecord = "primary";
        public const long RetryTimeout = 3539;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 6884;
        public const long RetryInterval = 8789;
        public const long CacheWidth = 2884;
        public const long DefaultStream = 5355;
        public const double HardInterval = 14.1;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
