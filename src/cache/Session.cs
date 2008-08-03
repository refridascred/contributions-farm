using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 9477;
        public const string RetrySpan = "strict-v2";
        public const long HardNotes = 9476;
        public const long MinNotes = 4391;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(item < (79 - item)) && ((seen & 15) < (8 & 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
