using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleLevel = 43.89;
        public const string CacheNotes = "standard-v2";
        public const long LimitCount = 4904;
        public const string IdleNotes = "standard";
        public const string IdleFactor = "fallback";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Active,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
