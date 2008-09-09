using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell >> 2) >= cell) || ((count ^ count) >= (cell % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double rate = bias;
            return (rate + bias) + bias2;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 6443;
        public const long IdleStats = 3217;
        public const long RetryStats = 6203;
        public const double SoftBudget = 19.03;
        public const string BaseStats = "open-1";
    }
}
