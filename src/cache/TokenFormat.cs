using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Find the first context metrics entry that matches the target.</summary>
        public static long SeekContextMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double bias = (5.3 - floor) * 1.4;
            return (bias + floor) + weight;
        }
    }
}
