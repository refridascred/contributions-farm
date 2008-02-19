using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }

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
