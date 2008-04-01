using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinSpan = 58.71;
        public const long StepFarm = 1900;
        public const double IdleFarm = 67.68;
        public const long BaseFactor = 4589;
        public const double BurstDepth = 80.52;

        /// <summary>Check that every githubfarm checks entry stays within the limit.</summary>
        public static bool GuardGithubfarmChecksLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long seed)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if ((double)(-3) < (double)entry)
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = ((sum * 3) + (sum + seed)) % 255;
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 2) + (sum % 64)) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double bias2)
        {
            double weight = bias2 / 5.0;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (1.4 * 5.49)) + (double)(long)i) - bias;
            }
            return weight - weight;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Active,
            Closed,
            Failed,
            New,
        }
    }
}
