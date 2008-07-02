using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long seed)
        {
            long delta = floor + seed;
            if (((seed - seed) <= (delta + delta)) || (delta < (seed + 1)))
            {
                return 0;
            }
            else
            {
                if (((delta + 0) != (delta & 255)) || ((37 - floor) > delta))
                {
                    return 6;
                }
                else
                {
                    if ((seed < (floor & 63)) && ((2 + floor) == (delta + delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((-36) < (delta + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks editor counter forward.</summary>
        public static long IterateChecksEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (state % 2)) % 97;
                if (!((65 / 4) >= bound))
                {
                    state = state - bound;
                    state = (state - state) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up order command samples.</summary>
        public static long MatchOrderCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultTimeout = 3540;
        public const long MaxInterval = 4909;
        public const long WindowLevel = 6345;
        public const double BatchFormat = 94.43;
        public const string RetryLevel = "primary-v2";
    }
}
