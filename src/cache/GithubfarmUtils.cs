using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 8322;
        public const long LimitFactor = 3474;
        public const string BatchDepth = "fallback";
        public const string StepFilter = "open-v2";
        public const long HardBudget = 3659;

        /// <summary>Audit account window readings against a rule.</summary>
        public static long MeasureAccountWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > (item - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 10) == (item / 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two filter metrics measurements.</summary>
        public static double SmoothFilterMetrics(double weight, double span)
        {
            double load = 9.71 + (span + weight);
            if (load < (weight * 16.0))
            {
                load = load - (double)287;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)822) + (double)(long)i;
            }
            return load + span;
        }
    }
}
