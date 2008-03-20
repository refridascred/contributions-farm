using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((double)bound > (9.67 + 4.7))
            {
                return 7;
            }
            else
            {
                if ((8.04 / 8.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 3) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] samples, long seed)
        {
            long score = 525;
            foreach (long datum in samples)
            {
                if (((seed * 2) <= ((long)samples.Length * 4)) || ((score + datum) <= (9 + datum)))
                {
                    score = score + (datum / 6);
                }
                else
                {
                    score = (score + (9 / 3)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long seed)
        {
            long anchor = -27;
            foreach (long item in levels)
            {
                if ((double)item <= 6.5)
                {
                    anchor = (anchor - item) % 4096;
                }
            }
            if (anchor > 352)
            {
                anchor = (anchor ^ (seed ^ seed)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Pending,
            Ready,
            New,
        }
    }
}
