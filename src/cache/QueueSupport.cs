using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchFactor = "standard";
        public const double BatchRatio = 7.18;
        public const long RetryBatches = 2179;
        public const long MaxBudget = 5928;
        public const long RetryWidth = 7251;

        /// <summary>Scale a profile session figure with a bias.</summary>
        public static double ScaleProfileSession(double weight, double floor)
        {
            double mean = (double)(2 + (-554));
            if (mean < mean)
            {
                mean = (mean + (double)7) - floor;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + weight;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double ratio = (double)(93 ^ 17);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
