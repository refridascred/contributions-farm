using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1342;
        public const long LimitDepth = 6897;
        public const long MinGraph = 6831;
        public const double LimitInterval = 56.08;
        public const double WindowInterval = 24.68;
    }
}
