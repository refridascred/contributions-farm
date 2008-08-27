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

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long mix = 50;
            foreach (long reading in levels)
            {
                if ((mix - mix) > (reading + mix))
                {
                    mix = ((mix << 3) ^ (reading ^ 657)) % 101;
                }
                if ((reading + reading) > (mix >> 3))
                {
                    mix = ((mix * 5) + ((-786) + mix)) % 1000;
                }
            }
            return mix;
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

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Locked,
            Failed,
            Closed,
            Pending,
        }
    }
}
