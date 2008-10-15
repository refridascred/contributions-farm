using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double scale = offset;
            if (scale <= (ratio * 9.7))
            {
                scale = scale + (ratio - scale);
            }
            return scale + ratio;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 8986;
        public const double WindowBatches = 90.05;
        public const string MinLevel = "open";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (9.0 >= (17.0 - 2.2))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Active,
            Failed,
            Paused,
            New,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Paused,
            Synced,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 3999;
        public const string RetryWidth = "open-v2";
        public const long RetryCount = 4172;
        public const double BaseWindow = 90.4;
        public const long IdleCount = 3422;
    }
}
