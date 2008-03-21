using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5365;
        public const string MaxCount = "open-v2";
        public const long RetryFormat = 1635;
        public const long HardScore = 7376;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count << 3) >= (origin - 6)) && ((9.01 + 1.94) > (double)count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
