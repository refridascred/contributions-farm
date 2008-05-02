using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Retry,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double bias, double bias2)
        {
            double scale = bias + bias;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - bias) + (double)(long)i) - bias2;
            }
            return scale - (scale + bias);
        }
    }
}
