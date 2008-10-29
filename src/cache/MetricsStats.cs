using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long seed)
        {
            if (((-2) - bound) >= bound)
            {
                return 8;
            }
            else
            {
                if ((seed <= (bound / 6)) || (bound < (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the commits farm entries that pass the check.</summary>
        public static long CountCommitsFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((double)hits == (8.5 + 14.0)) || ((hits % 60) >= reading)) && !(hits > reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (3.0 >= (double)offset)
                {
                    seen = (seen + 2) - sample;
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
