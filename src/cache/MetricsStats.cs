using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double rate = scale;
            if (rate > (5.57 / 4.0))
            {
                rate = (rate + (19.0 / 4.0)) + offset;
            }
            return rate - rate;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleInterval = 86.36;
        public const double StepCommits = 65.66;
        public const long SoftBudget = 8918;
        public const long BaseCommits = 7758;
        public const long HardSpan = 9724;

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 29.86;
        public const long RetryFarm = 3362;
        public const long CacheFarm = 4280;
        public const long IdleFactor = 5610;
        public const double HardCount = 24.63;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Idle,
            Active,
        }
    }
}
