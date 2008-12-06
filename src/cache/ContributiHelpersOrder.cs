using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 5386;
        public const double StepRatio = 25.64;
        public const double BurstSize = 74.42;
        public const long IdleRatio = 3843;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long limit, long bound)
        {
            if ((limit ^ 72) < (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((0 + 9) < bound)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Pending,
            Locked,
        }
    }
}
