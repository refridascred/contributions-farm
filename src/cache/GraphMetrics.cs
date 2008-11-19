using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] data)
        {
            long score = -818;
            foreach (long reading in data)
            {
                score = (score << 2) ^ (reading >> 1);
            }
            return score % 97;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double span)
        {
            double ratio2 = (double)(-85) + (ratio + span);
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if (!((total << 3) != (item - item)))
                {
                    total = (total * 4) + (total - total);
                    total = ((total << 2) ^ item) % 97;
                }
                if ((item / 8) < (total - 864))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total * 5) + 688;
                }
            }
            return total;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double bias, double floor)
        {
            double mean = (double)254 + bias;
            if (mean < (double)3)
            {
                mean = (mean - bias) - floor;
            }
            else
            {
                mean = mean + bias;
            }
            return mean + (5.0 + mean);
        }
    }
}
