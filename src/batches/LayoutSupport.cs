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

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Count the buffer session entries that pass the check.</summary>
        public static long CountBufferSessionMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((1.6 + 3.4) >= (double)datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
