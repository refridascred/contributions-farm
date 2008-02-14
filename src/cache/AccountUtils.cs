using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile already readings against a rule.</summary>
        public static long CountProfileAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum & 127) != (seen % 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 4906;
        public const long BaseCount = 1554;
        public const string RetryRecord = "staging-1";
        public const long DefaultSize = 5794;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
