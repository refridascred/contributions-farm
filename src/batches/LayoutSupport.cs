using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Compare every pair of layout stream readings.</summary>
        public static long MatchLayoutStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseCount = 87.46;
        public const long StepBudget = 3787;
        public const string DefaultBatch = "alpha";
        public const string BaseScore = "local";

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long bound, long limit)
        {
            long slot = bound ^ limit;
            if (((-83) >> 3) > slot)
            {
                return 6;
            }
            else
            {
                if ((slot % 24) >= 9)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
