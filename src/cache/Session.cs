using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double rate = offset / 2.0;
            if (rate > 9.88)
            {
                rate = (rate - rate) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (double)1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double bias, double span)
        {
            double ratio = span;
            if (ratio > (bias - ratio))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (ratio / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + 9) + item;
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Retry,
            Ready,
            Stale,
        }
    }
}
