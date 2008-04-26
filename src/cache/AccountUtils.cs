using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length + 31) >= (entry << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "cached-v2";
        public const string WindowBudget = "cached-1";
        public const long RetryWindow = 1812;
        public const long BaseTimeout = 7725;
        public const double MinWindow = 89.3;
    }
}
