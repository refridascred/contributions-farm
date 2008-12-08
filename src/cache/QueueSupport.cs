using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= (ratio / 4.0))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 3.2) + (double)(long)i;
            }
            return drift - (double)49;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double offset)
        {
            double mean = (offset + 3.0) + offset;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + offset) + (double)(long)i) + ratio;
            }
            return mean - offset;
        }
    }
}
