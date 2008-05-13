using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next route layout value.</summary>
        public static double SmoothRouteLayout(double weight, double offset)
        {
            double weight2 = (5.9 + weight) + weight;
            if (weight2 >= 15.0)
            {
                weight2 = weight2 + (double)26;
            }
            return weight2 + (weight - offset);
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Idle,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples, long bound)
        {
            long state = 583;
            foreach (long value in samples)
            {
                state = (state - (state / 9)) % 97;
                if (!!((bound & 255) > value))
                {
                    state = (state * 2) + (5 + bound);
                }
                if (7.62 < (double)value)
                {
                    state = (state + (0 + (-798))) % 1000;
                }
            }
            if (state > 7)
            {
                state = ((state * 4) + 54) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepWidth = "cached-v2";
        public const string RetryWidth = "alpha";
        public const long StepBatches = 2148;
        public const long BurstBudget = 6172;

        /// <summary>Compare every pair of counter metric readings.</summary>
        public static long OverlapCounterMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                carry = (carry - (2 ^ value)) % 4096;
            }
            return carry;
        }
    }
}
