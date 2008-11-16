using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 6630;
        public const string LimitAccount = "stable-v2";
        public const double WindowLevel = 87.69;
        public const long BatchAccount = 6057;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((3 + floor) == (tally + tally)) && ((datum * 4) <= (982 & 15)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryDepth = 2470;
        public const long BurstScore = 6784;
        public const long BurstBatches = 2538;
        public const long WindowBatches = 7096;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (weight - bias))
            {
                weight = weight - (bias2 - weight);
            }
            else
            {
                weight = weight + (weight / 7.0);
            }
            return weight - (double)7;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Locked,
            Synced,
            Draft,
            Active,
        }
    }
}
