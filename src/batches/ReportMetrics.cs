using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long seed, long offset)
        {
            if ((seed + 289) <= seed)
            {
                return 0;
            }
            else
            {
                if (seed >= (seed & 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of stats account entries.</summary>
        public static long ScoreStatsAccount(long[] values)
        {
            long sum = 416;
            foreach (long cell in values)
            {
                sum = sum ^ (171 >> 2);
                if ((9.9 - 7.0) < (double)cell)
                {
                    sum = (sum * 5) + (5 + cell);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Failed,
            Synced,
            Locked,
            Done,
        }
    }
}
