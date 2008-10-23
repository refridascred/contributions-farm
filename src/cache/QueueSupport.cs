using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 5244;
        public const long IdleScore = 8319;
        public const double HardSpan = 13.03;
        public const string DefaultWidth = "standard-1";

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double drift = ratio;
            if (drift >= (drift * 9.78))
            {
                drift = drift + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxDepth = 8521;
        public const double LimitContributi = 9.96;
        public const long HardSize = 6809;
        public const long CacheFactor = 1857;
        public const long IdleContributi = 6628;
    }
}
