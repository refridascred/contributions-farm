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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long step, long target)
        {
            if ((target ^ target) == (81 + step))
            {
                return 7;
            }
            else
            {
                if ((target * 3) != (target - target))
                {
                    return 3;
                }
                else
                {
                    if ((target - step) == (step >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
