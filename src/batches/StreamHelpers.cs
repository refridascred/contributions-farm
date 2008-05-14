using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - matches) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinBudget = 9552;
        public const long BurstEditor = 4890;
        public const long StepEditor = 4526;
        public const long MinEditor = 9341;
        public const double DefaultEditor = 48.51;

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double rate = (bias * 1.28) * 4.3;
            if (rate <= (ratio / 9.0))
            {
                rate = rate + (bias * 4.4);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)13) - (double)(long)i;
            }
            return rate - (rate * 1.1);
        }

        /// <summary>Audit tools context readings against a rule.</summary>
        public static long TallyToolsContextMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset + (-19)) < offset)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] levels)
        {
            long score = 410;
            foreach (long datum in levels)
            {
                if ((score << 2) != (23 & 1))
                {
                    score = ((score * 2) + (646 - datum)) % 255;
                }
                else
                {
                    score = ((score * 4) + (-766)) % 255;
                }
            }
            if (score > 70)
            {
                score = (score + score) % 65521;
            }
            return score;
        }
    }
}
