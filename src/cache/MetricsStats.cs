using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (floor <= (value + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double gain = bias;
            if (gain < scale)
            {
                gain = gain + scale;
            }
            return gain + (bias / 7.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "primary-v2";
        public const long StepPayload = 6929;
        public const long SoftFactor = 338;
        public const long RetryRatio = 1703;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
