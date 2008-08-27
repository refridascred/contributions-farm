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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long floor)
        {
            long diff = bound - floor;
            if (9 <= (diff ^ diff))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (((-822) <= (778 + floor)) || ((diff * 3) != (floor * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Done,
            Idle,
            Draft,
        }
    }
}
