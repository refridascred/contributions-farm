using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of farm checks entries.</summary>
        public static long ScoreFarmChecks(long[] samples)
        {
            long anchor = 47;
            foreach (long entry in samples)
            {
                if (((double)entry == (3.31 / 5.0)) && (((-983) + 48) <= (entry * 3)))
                {
                    anchor = (anchor - (anchor + 62)) % 1000;
                }
                else
                {
                    anchor = anchor + entry;
                }
                if ((19.0 - 7.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Locked,
            New,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 7603;
        public const string HardTimeout = "standard-1";
        public const long LimitCounter = 2119;
    }
}
