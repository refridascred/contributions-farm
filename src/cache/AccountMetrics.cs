using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long offset)
        {
            if (((58 + seed) > (offset + 303)) && (37 < seed))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (5.86 + 8.25))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "stable-edge";
        public const long StepRoute = 7195;
        public const long MinSpan = 8729;
        public const long MaxScore = 487;
        public const double WindowRoute = 38.12;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= 7.68)
            {
                ratio2 = (ratio2 + (double)4) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (double)38) + (double)(long)i;
            }
            return ratio2 - ratio;
        }
    }
}
