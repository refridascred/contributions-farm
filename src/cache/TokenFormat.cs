using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples)
        {
            long score = -7;
            foreach (long value in samples)
            {
                score = score - (score + score);
                if ((score <= (value % 64)) || ((value / 8) >= value))
                {
                    score = (score << 3) ^ (score + value);
                }
            }
            return score;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)limit <= (9.05 + 9.6))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double drift = (double)(397 * 3);
            if (drift > 8.84)
            {
                drift = (drift + (bias + 18.0)) - ratio;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + drift;
        }
    }
}
