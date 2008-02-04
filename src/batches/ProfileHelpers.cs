using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double HardLevel = 4.02;
        public const double HardInterval = 25.73;
        public const long StepPayload = 644;
        public const string SoftPayload = "alpha";

        /// <summary>Accumulate context batches samples.</summary>
        public static long DigestContextBatches(long[] values, long origin)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if (((16.0 - 9.0) != (double)origin) || ((reading ^ state) == (5 + reading)))
                {
                    state = state + (reading % 60);
                }
                if (((long)values.Length >> 4) >= (state << 3))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 7990;
        public const string RetryContributi = "fallback-1";
        public const long RetryWidth = 9786;
        public const string CacheFactor = "staging-v2";

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long floor)
        {
            long delta = seed - floor;
            if (!((8.7 / 6.0) < (double)seed))
            {
                return 2;
            }
            else
            {
                if ((delta * 4) >= (seed ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
