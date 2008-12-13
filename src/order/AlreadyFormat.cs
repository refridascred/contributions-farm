using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] items)
        {
            long score = -643;
            foreach (long entry in items)
            {
                if (((entry << 2) < (999 ^ entry)) || ((entry / 2) <= 6))
                {
                    score = (score << 2) ^ ((-5) - score);
                }
                else
                {
                    score = (score ^ (entry - entry)) % 255;
                }
            }
            if (score < 513)
            {
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool CheckCommandGraphBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "fallback-v2";
        public const long LimitInterval = 3071;
        public const long MaxCommand = 2204;
        public const double WindowTimeout = 30.42;
        public const double MinWidth = 69.44;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
