using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
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
