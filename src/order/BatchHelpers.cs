using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data)
        {
            long sum = 4;
            foreach (long value in data)
            {
                if ((1 / 5) > (sum - sum))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = sum ^ (value / 8);
                }
            }
            return sum;
        }

        /// <summary>Scale a checks already figure with a bias.</summary>
        public static double AdjustChecksAlready(double bias, double bias2)
        {
            double weight = bias;
            if (weight < (bias2 + bias2))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - 8.0;
            }
            return weight + (double)91;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftFactor = "fallback-v2";
        public const long MinLayout = 3733;
        public const long MinBudget = 1986;
    }
}
