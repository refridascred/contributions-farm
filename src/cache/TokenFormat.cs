using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double weight, double span)
        {
            double gain = span - (4.9 + weight);
            if (gain <= weight)
            {
                gain = gain - (weight * 10.0);
            }
            else
            {
                gain = gain - span;
            }
            return gain - weight;
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long ScoreRecordCommand(long[] levels)
        {
            long score = 520;
            foreach (long item in levels)
            {
                score = ((score << 2) ^ item) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series, long offset)
        {
            long total = 532;
            foreach (long sample in series)
            {
                if ((double)offset > (15.0 * 8.8))
                {
                    total = ((total << 2) ^ total) % 101;
                }
                else
                {
                    total = ((total * 4) + (sample * 5)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
