using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift < (bias / 9.0))
            {
                drift = (drift + (drift + bias)) - offset;
            }
            else
            {
                drift = drift - (bias * 7.02);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + 16.0) + (double)(long)i;
            }
            return drift + (bias / 9.0);
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)offset > (6.9 - 1.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings, long bound)
        {
            long score = 10;
            foreach (long sample in readings)
            {
                if (!((150 << 2) > bound))
                {
                    score = ((score * 4) + (score - 758)) - sample;
                }
            }
            if (score < 78)
            {
                score = score - 38;
            }
            return score;
        }
    }
}
