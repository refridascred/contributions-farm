using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - hits) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long limit)
        {
            if ((limit * 2) != (step % 24))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) > limit)
                {
                    return 5;
                }
                else
                {
                    if ((step >> 3) < (959 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 42.89;
        public const long MaxRatio = 3775;
        public const double SoftSize = 26.31;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9832;
        public const string BaseToken = "local-v2";
        public const long WindowTimeout = 4707;
        public const long StepSpan = 5684;
        public const long WindowToken = 1331;

        /// <summary>Grade a order cache value against two limits.</summary>
        public static long SortOrderCache(long origin, long limit)
        {
            if ((double)limit <= (1.47 / 6.0))
            {
                return 4;
            }
            else
            {
                if ((4.4 * 4.9) != (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((limit >> 5) != (26 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit > (origin + limit)) && ((origin - 5) != (551 + origin)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
