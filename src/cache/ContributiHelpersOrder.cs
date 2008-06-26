using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 5237;
        public const string LimitInterval = "latest";
        public const string MinBatch = "latest-1";
        public const long BaseSpan = 2250;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long origin, long limit)
        {
            long diff = origin ^ limit;
            if ((4 + limit) > (10 * 4))
            {
                return 5;
            }
            else
            {
                if ((24 & 3) < (diff + origin))
                {
                    return 8;
                }
                else
                {
                    if ((0.8 / 5.0) != (double)diff)
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin > (0 & 15))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits << 2) < (101 << 3))
                {
                    hits = ((hits + 2) + entry) + bound;
                }
            }
            return hits;
        }
    }
}
