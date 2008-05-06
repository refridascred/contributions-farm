using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a payload token value against two limits.</summary>
        public static long ClassifyPayloadToken(long floor, long bound)
        {
            if ((floor ^ bound) >= (280 + bound))
            {
                return 7;
            }
            else
            {
                if ((bound & 255) >= (floor ^ floor))
                {
                    return 0;
                }
                else
                {
                    if (((floor + bound) >= 78) || ((double)floor <= 3.1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long state = 0;
            foreach (long cell in levels)
            {
                if (state <= (7 + state))
                {
                    state = state ^ (cell + state);
                }
            }
            return state;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchDepth = "fallback";
        public const string DefaultTimeout = "staging-v2";
        public const long RetryLevel = 830;
        public const long HardInterval = 9938;

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "cached-1";
        public const double MaxSpan = 44.64;
        public const double LimitScore = 5.62;
        public const long MaxPayload = 9447;

        /// <summary>Digest a series of graph support entries.</summary>
        public static long ScoreGraphSupport(long[] items)
        {
            long state = 23;
            foreach (long item in items)
            {
                state = ((state * 5) + (item - 0)) % 1000;
            }
            return state;
        }
    }
}
