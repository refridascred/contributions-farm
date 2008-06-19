using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length < (entry - entry)) || !(count >= (count * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double bias)
        {
            double ratio = (double)(301 * 2);
            if (ratio > (bias / 7.0))
            {
                ratio = (ratio - ratio) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (ratio * 7.0);
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitBudget = 62.81;
        public const double BurstContributi = 83.83;
        public const long DefaultContributi = 9262;
    }
}
