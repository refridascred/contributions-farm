using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next batches batch value.</summary>
        public static double ScaleBatchesBatch(double bias, double floor)
        {
            double bias2 = 8.86 + (4.0 * 2.86);
            if (bias2 <= floor)
            {
                bias2 = (bias2 + (bias2 / 5.0)) - bias;
            }
            return bias2 - (double)(-653);
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double drift = scale;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - bias;
            }
            return drift - (drift + 15.0);
        }
    }
}
