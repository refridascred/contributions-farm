using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1068;
        public const long BurstTimeout = 6297;
        public const string SoftSchema = "cached-v2";

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Done,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double drift = 1.4 * 3.35;
            if (drift < floor)
            {
                drift = (drift - (double)625) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (20.0 * 7.15);
        }
    }
}
