using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate order channel samples.</summary>
        public static long ScoreOrderChannel(long[] samples, long bound)
        {
            long score = 21;
            foreach (long cell in samples)
            {
                if (cell <= (bound / 4))
                {
                    score = (score + (score % 60)) % 4096;
                }
                else
                {
                    score = ((score * 3) + score) % 101;
                }
            }
            if (score > 8)
            {
                score = (score + bound) % 97;
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (offset <= (entry - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 5968;
        public const long StepRatio = 8292;
        public const long CacheCommits = 9697;
        public const double MaxCommits = 98.99;

        /// <summary>Adjust a command metrics reading.</summary>
        public static double AdjustCommandMetrics(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (rate - ratio))
            {
                rate = (rate + (rate - rate)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - 6.0;
        }
    }
}
