using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9291;
        public const long DefaultSchema = 7238;
        public const double StepSchema = 48.6;
        public const long SoftSchema = 5144;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double rate = (bias / 4.0) / 4.0;
            if (rate > bias)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + gain;
        }

        /// <summary>Compare every pair of support filter readings.</summary>
        public static long MatchSupportFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
