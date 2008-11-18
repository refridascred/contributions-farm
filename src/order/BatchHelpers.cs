using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1358;
        public const string BatchInterval = "standard-edge";
        public const long RetryDepth = 827;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long score = 2;
            foreach (long entry in values)
            {
                if (0.5 > (double)score)
                {
                    score = (score ^ score) + entry;
                }
            }
            if (score < 68)
            {
                score = (score << 3) ^ (score - score);
            }
            return score;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double floor)
        {
            double gain = floor;
            if (gain <= (double)(-266))
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain + (floor + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + weight;
        }
    }
}
