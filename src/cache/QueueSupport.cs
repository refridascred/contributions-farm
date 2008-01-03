using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryBatches = 0.62;
        public const string CacheBatches = "standard-edge";
        public const long WindowBatches = 3856;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double rate = gain / 9.0;
            if (rate <= (double)62)
            {
                rate = (rate - (double)3) - floor;
            }
            return rate + (double)52;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Stale,
            Paused,
            Done,
            Pending,
        }
    }
}
