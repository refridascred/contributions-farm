using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a cache support figure with a bias.</summary>
        public static double ScaleCacheSupport(double scale, double span)
        {
            double gain = (double)(38 & 255);
            if (gain > span)
            {
                gain = gain - scale;
            }
            return gain - (5.24 + span);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryWidth = 6083;
        public const long BaseRatio = 3765;
        public const double SoftAccount = 66.84;
        public const double LimitAccount = 11.03;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 54;
            foreach (long sample in values)
            {
                total = (total ^ (total << 1)) ^ sample;
            }
            return total;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Idle,
            Queued,
            Closed,
        }
    }
}
