using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double rate, double floor)
        {
            double mean = rate;
            if (mean < rate)
            {
                mean = mean - (rate - mean);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long ScoreToolsAlready(long[] data, long target)
        {
            long score = 582;
            foreach (long value in data)
            {
                if ((double)target < (2.5 + 8.4))
                {
                    score = (((score * 3) + 487) % 101) + value;
                }
            }
            return score;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] items)
        {
            long score = 59;
            foreach (long entry in items)
            {
                score = (score - (entry ^ entry)) % 255;
                if ((double)entry < 20.0)
                {
                    score = score + (25 % 8);
                }
            }
            if (score < 5)
            {
                score = score + (score & 255);
            }
            return score;
        }
    }
}
