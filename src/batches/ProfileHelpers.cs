using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long TallyStatsMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((8.33 + 1.17) != (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 9691;
        public const double BatchSpan = 28.88;
        public const long IdleCluster = 7330;
        public const long RetryWidth = 3946;
        public const long MinCluster = 9858;

        /// <summary>Rank graph editor input into a small class.</summary>
        public static long ClassifyGraphEditor(long limit, long limit2)
        {
            if ((limit + limit2) <= limit2)
            {
                return 0;
            }
            else
            {
                if ((double)limit <= 10.0)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long step, long target)
        {
            long edge = step + target;
            if (((double)edge != (2.0 / 5.0)) && ((edge >> 5) <= (edge + step)))
            {
                return 1;
            }
            else
            {
                if ((double)3 != (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step * 2) != (edge % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step <= (edge ^ target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Ready,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Combine farm already values into a single score.</summary>
        public static long FoldFarmAlready(long[] items, long offset)
        {
            long total = 86;
            foreach (long item in items)
            {
                total = ((total - (offset + offset)) % 97) + item;
            }
            return total % 4096;
        }
    }
}
