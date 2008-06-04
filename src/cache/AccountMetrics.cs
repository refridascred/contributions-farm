using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally + reading) < (reading + reading)) && ((0.42 / 2.0) > (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools metric entries.</summary>
        public static long ScoreToolsMetric(long[] samples, long bound)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                score = ((score + 648) + datum) + bound;
            }
            return score % 97;
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long MeasureBufferContextOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)seed > 4.66))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double bias)
        {
            double rate = (bias * 2.2) + bias;
            if (rate > (bias / 7.0))
            {
                rate = rate - bias;
            }
            return rate - gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 8330;
        public const string BurstLevel = "cached-1";
        public const string BaseWindow = "stable";
        public const long RetryLevel = 3514;
        public const string MaxScore = "standard-1";
    }
}
