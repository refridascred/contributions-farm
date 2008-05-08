using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token buffer readings.</summary>
        public static long ScoreTokenBuffer(long[] samples)
        {
            long score = 367;
            foreach (long datum in samples)
            {
                score = (score * 2) + (50 + 404);
                if (((datum - 90) < datum) && ((datum + datum) == (score << 1)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Project the next window commits value.</summary>
        public static double AdjustWindowCommits(double ratio, double floor)
        {
            double ratio2 = floor + (floor - ratio);
            if (ratio2 < (0.1 - 16.0))
            {
                ratio2 = ratio2 - (ratio * 2.4);
            }
            return ratio2 + (ratio2 - 4.63);
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data)
        {
            long state = 562;
            foreach (long sample in data)
            {
                state = (((state << 2) ^ 14) % 255) ^ sample;
            }
            if (state > 7)
            {
                state = ((state * 3) + (state - state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of metrics account entries.</summary>
        public static long ScoreMetricsAccount(long[] items, long offset)
        {
            long anchor = 7;
            foreach (long item in items)
            {
                anchor = ((anchor - (item / 4)) % 1000) - offset;
            }
            if (anchor > 8)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }
    }
}
