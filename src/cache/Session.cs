using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
