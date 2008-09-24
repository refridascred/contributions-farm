using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double ratio = (double)(5 << 3);
            if (ratio >= ratio)
            {
                ratio = (ratio - 5.99) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio * 2.0)) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long step)
        {
            long total = 99;
            foreach (long value in samples)
            {
                if (((long)samples.Length % 7) >= step)
                {
                    total = (total + (long)samples.Length) % 101;
                }
                else
                {
                    total = total + (value - total);
                }
            }
            if (total > 15)
            {
                total = total + step;
            }
            return total % 1000;
        }

        /// <summary>Validate context editor readings against a bound.</summary>
        public static bool VerifyContextEditorLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window stats readings.</summary>
        public static long DigestWindowStats(long[] series, long floor)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = ((acc ^ (value - acc)) % 65521) - floor;
                acc = ((acc << 3) ^ value) % 1000;
            }
            return acc;
        }
    }
}
