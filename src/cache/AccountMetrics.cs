using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of session account entries.</summary>
        public static long ScoreSessionAccount(long[] series)
        {
            long anchor = 77;
            foreach (long datum in series)
            {
                anchor = ((anchor + (anchor >> 3)) % 1000) - datum;
            }
            return anchor;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleDepth = 53.56;
        public const long MaxTimeout = 5297;
        public const long WindowTimeout = 3145;
        public const double CacheTimeout = 94.93;
        public const string BaseRoute = "cached-v2";

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Locked,
            Done,
            New,
            Active,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings, long target)
        {
            long total = -9;
            foreach (long datum in readings)
            {
                if ((target < datum) && (total > (target + target)))
                {
                    total = total - (287 + datum);
                }
            }
            return total;
        }
    }
}
