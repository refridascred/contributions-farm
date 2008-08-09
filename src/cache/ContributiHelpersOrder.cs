using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + offset) >= offset)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double weight, double bias)
        {
            double bias2 = (double)(14 % 97);
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 - bias2) - (double)(long)i) + bias;
            }
            return bias2 - weight;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
