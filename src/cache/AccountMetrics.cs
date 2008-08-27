using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of checks metric readings.</summary>
        public static long FoldChecksMetric(long[] series)
        {
            long result = -2;
            foreach (long datum in series)
            {
                if ((result + result) <= (result + datum))
                {
                    result = (result ^ (result / 5)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double floor)
        {
            double weight = 2.0;
            if (weight > floor)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + (weight * 3.1);
            }
            return weight - rate;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseAlready = 55.58;
        public const double IdleSize = 21.21;
        public const double BaseBudget = 71.05;
        public const long BurstBudget = 6200;
        public const double MaxAlready = 47.4;

        /// <summary>Roll a batches window counter forward.</summary>
        public static long SeriesBatchesWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                if (score <= (long)i)
                {
                    score = ((score * 2) + (target + 435)) % 255;
                }
                long hits = ((long)i << 3) & 127;
                score = (score + (hits % 3)) % 1000;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell != (0.2 - 9.1))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
