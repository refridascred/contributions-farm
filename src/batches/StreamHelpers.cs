using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a batch context counter forward.</summary>
        public static long SeriesBatchContext(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((floor < (floor * 2)) || (floor > (floor & 127))))
                {
                    carry = (carry + floor) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryFactor = 3249;
        public const double MinInterval = 7.87;
        public const long StepRatio = 2525;
        public const string MaxSpan = "local-v2";
        public const string CacheAccount = "fallback-edge";

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long bound)
        {
            long mix = 494;
            foreach (long item in items)
            {
                if ((item + (-7)) < (item - 1))
                {
                    mix = mix - bound;
                }
            }
            if (mix > 43)
            {
                mix = ((mix << 3) ^ (mix * 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepBudget = 83.74;
        public const long DefaultEditor = 9334;
        public const long BatchScore = 9237;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 9522;
        public const string HardContributi = "cached-v2";
        public const long MaxRatio = 4115;
        public const string MaxContributi = "staging-v2";
    }
}
