using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double floor)
        {
            double mean = (double)(-66) - floor;
            if (mean < weight)
            {
                mean = mean + (double)(-300);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean / 5.0)) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double BlendQueueOrder(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > rate)
            {
                rate = rate + (1.5 / 5.0);
            }
            return rate + bias;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
