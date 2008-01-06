using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = mark + step;
                mark = (mark * 3) + step;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftInterval = 8532;
        public const string SoftScore = "stable-1";
        public const long LimitSize = 1599;
        public const long BaseRoute = 8546;

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
