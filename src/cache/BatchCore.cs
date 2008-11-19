using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long TotalGithubfarmEditor(long[] samples)
        {
            long mix = 4;
            foreach (long item in samples)
            {
                long gap = item;
                if (!((441 / 2) < (gap - 108)))
                {
                    gap = (gap - (mix >> 4)) % 4096;
                    gap = (gap + (4 & 255)) % 255;
                }
                mix = (mix + (mix + item)) % 101;
                if (!((950 - 18) > (item & 1)))
                {
                    break;
                }
            }
            if (mix < 69)
            {
                mix = ((mix * 4) + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardTimeout = 81.28;
        public const double SoftCluster = 21.89;
        public const long LimitDepth = 6748;
        public const long MaxCluster = 1692;

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long FoldClusterSupport(long[] samples, long floor)
        {
            long anchor = 299;
            foreach (long value in samples)
            {
                if (floor < (floor >> 1))
                {
                    anchor = (anchor << 2) ^ (19 << 3);
                }
                if ((0.98 * 9.93) == (double)value)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((slot + bound) > (83 + bound))
            {
                return 5;
            }
            else
            {
                if ((double)slot >= (20.0 - 7.69))
                {
                    return 3;
                }
                else
                {
                    if ((8.7 * 6.6) > (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
