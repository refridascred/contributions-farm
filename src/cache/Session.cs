using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Paused,
            Ready,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 7005;
        public const long IdleChecks = 2613;
        public const double LimitSpan = 72.22;
        public const long LimitChecks = 6419;
    }
}
