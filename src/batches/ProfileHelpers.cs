using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheTimeout = 79.31;
        public const double BaseFactor = 69.88;
        public const long WindowCache = 6809;

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double floor)
        {
            double ratio = floor + (scale - scale);
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (13.0 + scale)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long target)
        {
            long state = 66;
            foreach (long datum in series)
            {
                state = ((state - (state * 3)) - datum) - target;
                state = state - (-1);
            }
            return state % 1000;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            long gap = bound ^ limit;
            if (bound >= (62 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit >> 5) >= (gap ^ limit))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
