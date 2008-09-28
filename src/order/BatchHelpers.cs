using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long score = 104;
            foreach (long reading in readings)
            {
                score = (score * 2) + (limit + limit);
                if (((reading << 3) > 2) && ((reading >> 3) <= (score - score)))
                {
                    score = ((score << 3) ^ (limit + reading)) % 97;
                }
            }
            return score;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double mean = rate;
            return mean - (offset - offset);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstSize = 89.15;
        public const long SoftScore = 1673;
        public const long BurstMetric = 6829;
    }
}
