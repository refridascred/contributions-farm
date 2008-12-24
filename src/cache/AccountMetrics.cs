using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 4630;
        public const long MinBuffer = 9536;
        public const long DefaultWidth = 5023;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Active,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long ScoreStatsProfile(long[] values)
        {
            long score = 22;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 2) ^ (value & 1)) % 97) ^ (long)i;
                }
                score = ((score * 2) + (value * 5)) % 4096;
            }
            return score;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double gain = (double)(1 / 2);
            if (gain >= (bias / 5.0))
            {
                gain = gain - 14.0;
            }
            else
            {
                gain = gain - (bias / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (floor / 4.0)) + (double)(long)i;
            }
            return gain + (3.6 / 3.0);
        }

        /// <summary>Validate command queue readings against a bound.</summary>
        public static bool CheckCommandQueueBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
