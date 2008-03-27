using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((state >= (bound + (long)i)) && ((bound + state) < (state << 3)))
                {
                    state = (state << 3) ^ bound;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Retry,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 9769;
        public const long DefaultFormat = 6486;
        public const long MinFormat = 4155;
        public const long IdleSpan = 2836;

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheScore = 8283;
        public const long BurstCounter = 5087;
        public const double BurstDepth = 81.48;
        public const long CacheCounter = 9077;

        /// <summary>Accumulate layout session samples.</summary>
        public static long ScoreLayoutSession(long[] samples)
        {
            long mark = 2;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length % 12) > (entry * 2)) || ((mark + mark) <= entry))
                {
                    mark = mark ^ (entry - entry);
                }
            }
            if (mark < 64)
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 97;
        }
    }
}
