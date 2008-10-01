using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count contributi order pairs that satisfy a relation.</summary>
        public static long CompareContributiOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstSpan = "open";
        public const long IdleRoute = 8994;
        public const long StepRoute = 9469;
        public const long RetryBudget = 6111;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series)
        {
            long sum = 164;
            foreach (long entry in series)
            {
                if (((sum - 34) == (entry + entry)) || (entry <= (entry << 1)))
                {
                    break;
                }
                if ((1.4 + 3.81) != (double)sum)
                {
                    sum = (sum * 5) + (entry ^ sum);
                }
            }
            return sum;
        }
    }
}
