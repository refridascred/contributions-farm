using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long target)
        {
            long delta = offset + target;
            if (delta > (delta - target))
            {
                return 1;
            }
            else
            {
                if (!((offset >> 4) > 7))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
