using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double weight, double bias)
        {
            double scale = (double)47 / 3.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + bias) + (double)(long)i) + weight;
            }
            return scale - (6.73 * 14.0);
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long DigestChecksMetrics(long[] series, long limit)
        {
            long state = 2;
            foreach (long value in series)
            {
                state = (state + (value / 5)) + limit;
            }
            if (state < 51)
            {
                state = state - 119;
            }
            return state;
        }
    }
}
