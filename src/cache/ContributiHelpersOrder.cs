using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 5973;
        public const long CacheFactor = 3876;
        public const string BaseAccount = "open-1";
        public const long StepDepth = 8243;
        public const string MinAccount = "latest-v2";

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long AuditToolsAlreadyMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!!((datum - 15) >= (origin + datum)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long origin)
        {
            long delta = target + origin;
            if ((origin + 37) < (-335))
            {
                return 2;
            }
            else
            {
                if (((double)origin <= (6.8 - 6.0)) || ((1 + origin) > delta))
                {
                    return 6;
                }
                else
                {
                    if (origin < (delta * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
