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

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long offset)
        {
            if (offset >= target)
            {
                return 7;
            }
            else
            {
                if (!((double)7 == (double)target))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + target) >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
