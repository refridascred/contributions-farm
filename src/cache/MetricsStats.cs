using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Idle,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 2690;
        public const double BatchSize = 17.72;
        public const long BurstCache = 7555;

        /// <summary>Fold a list of route batch readings.</summary>
        public static long DigestRouteBatch(long[] values)
        {
            long state = 3;
            foreach (long item in values)
            {
                if (state >= (state + 871))
                {
                    state = (state - (item + state)) % 97;
                }
                else
                {
                    state = (state - (item + state)) % 65521;
                }
                if ((item <= (state ^ state)) && (((-524) >> 5) == (state - state)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long target)
        {
            long gap = step ^ target;
            if ((16.0 / 9.0) >= (double)target)
            {
                return 8;
            }
            else
            {
                if (target > (gap + 9))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
