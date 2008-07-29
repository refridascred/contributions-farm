using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 7357;
        public const long RetryScore = 3602;
        public const long WindowGraph = 1037;
        public const double StepBudget = 32.1;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long origin)
        {
            long mix = 358;
            foreach (long item in data)
            {
                mix = ((mix ^ (origin >> 1)) % 97) ^ item;
            }
            if (mix < 38)
            {
                mix = mix + (long)data.Length;
            }
            return mix;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double drift = span;
            return drift - (9.76 + bias);
        }
    }
}
