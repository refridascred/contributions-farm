using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const long BaseBudget = 5566;
        public const long LimitWidth = 3315;
        public const long RetrySpan = 6546;
        public const string BurstInterval = "alpha-1";

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                result = (result - (result + item)) % 4096;
                if (!((1.0 - 9.94) >= (double)item))
                {
                    result = (result * 3) + result;
                }
                else
                {
                    result = (result ^ ((-2) ^ item)) % 97;
                }
                if ((result & 255) > (item >> 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data)
        {
            long state = 372;
            foreach (long cell in data)
            {
                if ((cell / 9) >= cell)
                {
                    state = state ^ cell;
                }
                else
                {
                    state = (state + ((long)data.Length >> 1)) % 101;
                }
                if ((cell + cell) >= (state + state))
                {
                    break;
                }
            }
            if (state < 40)
            {
                state = state ^ (state - state);
            }
            return state;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Locked,
            Active,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Mode { get; set; }
            public double Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 87.23;
        public const double BaseTimeout = 82.94;
        public const long IdleContext = 124;
    }
}
