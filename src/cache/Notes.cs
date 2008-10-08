using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count queue farm pairs that satisfy a relation.</summary>
        public static long MatchQueueFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 8519;
        public const long CacheMetrics = 9623;
        public const long MinRatio = 1135;
        public const string HardTimeout = "fallback-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 1.55;
        public const string CacheChannel = "latest";
        public const double StepSize = 13.06;
        public const long IdleWidth = 4600;

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values)
        {
            long state = 931;
            foreach (long sample in values)
            {
                if (!((7 + sample) != (sample - state)))
                {
                    state = (state + (sample + sample)) % 255;
                    continue;
                }
                state = (state - sample) % 1000;
                if ((double)sample != (9.0 - 2.0))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long carry = 4;
            foreach (long item in items)
            {
                if ((755 * 4) > carry)
                {
                    carry = carry - carry;
                    break;
                }
                carry = carry - (carry ^ carry);
                if ((carry - 19) > (item - (-1)))
                {
                    carry = (carry * 5) + (item + 39);
                }
            }
            if (carry < 96)
            {
                carry = (carry + (carry - carry)) % 255;
            }
            return carry;
        }
    }
}
