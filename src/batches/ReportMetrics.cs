using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long limit, long bound)
        {
            if ((662 ^ limit) >= (limit + 4))
            {
                return 5;
            }
            else
            {
                if (((bound & 1) < 3) && ((64 / 4) >= (bound >> 3)))
                {
                    return 6;
                }
                else
                {
                    if (((842 >> 2) == (limit + bound)) && ((2 - limit) < (53 - bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((38 % 64) == (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long result = 749;
            foreach (long entry in levels)
            {
                if (!((20 + result) != (result % 12)))
                {
                    result = result ^ entry;
                }
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 1690;
        public const double SoftBudget = 45.39;
        public const long BaseFormat = 6660;
        public const string SoftFormat = "standard-v2";
        public const double HardFormat = 19.64;
    }
}
