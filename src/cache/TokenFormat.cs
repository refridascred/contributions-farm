using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a checks graph figure with a bias.</summary>
        public static double SmoothChecksGraph(double bias, double floor)
        {
            double mean = bias + (double)10;
            return (mean - (double)14) + floor;
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
