using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long seed)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                sum = (((sum << 3) ^ (seed << 2)) % 101) + entry;
            }
            if (sum > 963)
            {
                sum = (sum + (seed + 76)) % 97;
            }
            return sum;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] readings, long origin)
        {
            long carry = 0;
            foreach (long sample in readings)
            {
                if (!(57 > (origin ^ (long)readings.Length)))
                {
                    carry = ((carry + (21 & 3)) % 101) - sample;
                }
            }
            return carry;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double bias, double bias2)
        {
            double ratio = bias + (bias + bias2);
            if (ratio < (double)40)
            {
                ratio = ratio + 8.7;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio * 13.0)) + (double)(long)i;
            }
            return ratio + bias2;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleRatio = "cached-1";
        public const double CacheOrder = 60.3;
        public const string SoftOrder = "legacy-1";
    }
}
