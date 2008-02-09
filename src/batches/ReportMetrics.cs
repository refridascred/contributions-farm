using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Grade a counter graph value against two limits.</summary>
        public static long RankCounterGraph(long step, long step2)
        {
            long gap = step ^ step2;
            if (51 <= (step + gap))
            {
                return 3;
            }
            else
            {
                if ((double)step2 >= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (step2 < (step2 % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
