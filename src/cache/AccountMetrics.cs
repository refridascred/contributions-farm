using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double RetryTimeout = 77.51;
        public const double DefaultFormat = 96.68;
        public const double BurstFormat = 69.39;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double scale = rate;
            if (scale > (rate - rate))
            {
                scale = (scale + rate) + span;
            }
            return scale - rate;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if ((origin - origin) > (origin * 2))
            {
                return 8;
            }
            else
            {
                if (!((seed & 31) != (seed - 841)))
                {
                    return 7;
                }
                else
                {
                    if ((72 + origin) <= 410)
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed > (origin + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 54.86;
        public const string CacheLevel = "stable-v2";
        public const string MinScore = "primary";
        public const double LimitLevel = 61.13;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Stale,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Accumulate stream profile samples.</summary>
        public static long DigestStreamProfile(long[] samples, long bound)
        {
            long state = 5;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (-7))
                {
                    state = (state * 3) + (bound + bound);
                }
            }
            if (state < 8)
            {
                state = state ^ (632 >> 1);
            }
            return state;
        }
    }
}
