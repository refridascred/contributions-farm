using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 13.08;
        public const long SoftSupport = 2422;
        public const string MinRatio = "stable-1";
        public const double HardSupport = 59.5;
        public const long CacheSupport = 3379;

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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSize = 7090;
        public const long BaseTimeout = 5814;
        public const double DefaultNotes = 51.23;
        public const long BatchNotes = 9862;
        public const long MaxNotes = 7333;
    }
}
