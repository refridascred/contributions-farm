using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((486 - cell) > (floor & 7))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] values, long offset)
        {
            long mark = -748;
            foreach (long cell in values)
            {
                if ((mark + 931) > (offset / 8))
                {
                    mark = (mark - cell) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSpan = 7232;
        public const long WindowAccount = 1330;
        public const long DefaultSize = 7675;
        public const long MaxFactor = 7112;
        public const long BaseFactor = 6513;
    }
}
