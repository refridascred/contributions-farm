using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxInterval = 961;
        public const long BaseNotes = 6909;
        public const long BurstBudget = 4468;

        /// <summary>Accumulate stats notes samples.</summary>
        public static long ScoreStatsNotes(long[] levels, long limit)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((reading >> 2) <= (limit - limit))
                {
                    score = (score ^ limit) % 4096;
                }
            }
            if (score > 36)
            {
                score = (score * 4) + (score + limit);
            }
            return score % 97;
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long CountMetricsEditorOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((target * 5) == (target + target)) && !((4.7 - 0.82) > (double)target))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 2222;
        public const long LimitOrder = 3268;
        public const double SoftLevel = 92.71;
        public const long SoftOrder = 2808;
    }
}
