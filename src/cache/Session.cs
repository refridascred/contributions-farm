using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Ready,
            Paused,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Retry,
            Stale,
            New,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 43.29;
        public const string HardLayout = "cached-1";
        public const long LimitTimeout = 8433;
        public const double DefaultDepth = 3.26;
        public const long RetryLayout = 1844;
    }
}
