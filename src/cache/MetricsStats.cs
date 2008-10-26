using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long TallyLayoutWindowMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(tally < (sample + limit)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Locked,
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double scale = (double)(657 ^ 7);
            return (scale + (weight * 4.53)) + bias;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7050;
        public const double StepBudget = 18.69;
        public const string RetrySize = "primary-edge";
    }
}
