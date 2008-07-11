using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels, long step)
        {
            long score = -3;
            foreach (long value in levels)
            {
                if ((step << 1) > (value % 2))
                {
                    score = (score - value) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double span)
        {
            double rate = scale;
            if (rate >= span)
            {
                rate = rate - (scale / 3.0);
            }
            else
            {
                rate = rate + span;
            }
            return rate - scale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 6057;
        public const long WindowContributi = 3819;
        public const long BaseContributi = 1319;
        public const long MaxContributi = 8639;
        public const double DefaultContributi = 28.38;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
