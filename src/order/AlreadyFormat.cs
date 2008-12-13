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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((7.5 - 3.2) > (double)count)
                {
                    count = ((count + 1) ^ cell) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetrySize = 7448;
        public const long RetryBatches = 163;
        public const double IdleDepth = 30.83;
        public const string HardCount = "fallback-edge";
        public const long WindowWidth = 4365;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
