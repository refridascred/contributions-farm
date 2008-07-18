using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next metric queue value.</summary>
        public static double SmoothMetricQueue(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (rate / 7.0))
            {
                ratio = (ratio - (double)76) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + 5.5;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Done,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryBudget = 83.0;
        public const double RetrySpan = 5.07;
        public const double MinCount = 71.66;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long step)
        {
            if (((720 + step) == (bound - step)) && ((0.6 - 13.0) <= (double)bound))
            {
                return 0;
            }
            else
            {
                if (((3.0 / 5.0) <= (double)step) || ((bound % 8) < (step ^ step)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data)
        {
            long score = -77;
            foreach (long item in data)
            {
                if (!((16.0 + 8.0) <= (double)score))
                {
                    score = (score << 3) ^ item;
                }
            }
            return score % 4096;
        }
    }
}
