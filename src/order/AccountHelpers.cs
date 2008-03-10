using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 83.54;
        public const string HardSpan = "staging-v2";
        public const double HardRatio = 8.44;
        public const long StepFactor = 784;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryBudget = 335;
        public const long MaxStats = 4399;
        public const double MinFactor = 86.2;
        public const long BurstSize = 2913;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values)
        {
            long mark = 35;
            foreach (long entry in values)
            {
                mark = mark - ((-862) >> 2);
                if (((double)entry == (double)mark) || ((mark + mark) >= 8))
                {
                    mark = (mark - mark) % 97;
                }
            }
            if (mark < 6)
            {
                mark = (mark + (mark ^ mark)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (683 > cell)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
