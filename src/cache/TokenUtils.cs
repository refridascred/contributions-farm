using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftLevel = "local-1";
        public const string IdleFormat = "cached-v2";
        public const double WindowScore = 86.73;
        public const long BaseDepth = 3995;

        /// <summary>Rank report commits input into a small class.</summary>
        public static long RankReportCommits(long bound, long origin)
        {
            if (bound >= (origin - origin))
            {
                return 8;
            }
            else
            {
                if (((-327) & 127) != (origin - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 5) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
