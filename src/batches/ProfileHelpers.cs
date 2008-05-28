using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "stable";
        public const double DefaultToken = 98.22;
        public const string WindowRatio = "staging-edge";
        public const double RetryToken = 4.29;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((seed ^ origin) < seed)
            {
                return 3;
            }
            else
            {
                if (!((double)origin != (3.89 + 3.6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double bias, double offset)
        {
            double scale = 8.0;
            if (scale <= 20.0)
            {
                scale = (scale + (offset * 2.0)) + bias;
            }
            return scale - (double)917;
        }

        /// <summary>Accumulate cache metric samples.</summary>
        public static long TotalCacheMetric(long[] levels)
        {
            long mix = 46;
            foreach (long cell in levels)
            {
                if ((((-395) + 0) > (70 - cell)) || ((cell + 4) < cell))
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            Closed,
            Synced,
            Dropped,
            Locked,
        }
    }
}
