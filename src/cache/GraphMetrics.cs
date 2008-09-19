using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long origin, long step)
        {
            long edge = origin ^ step;
            if (((6 + edge) <= (edge >> 4)) || ((edge >> 4) < (step & 15)))
            {
                return 7;
            }
            else
            {
                if ((step * 2) <= edge)
                {
                    return 4;
                }
                else
                {
                    if ((9.1 * 8.0) < (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long origin)
        {
            long bound = target ^ origin;
            if (((target & 63) < (964 * 3)) || ((double)target > (4.76 + 8.66)))
            {
                return 4;
            }
            else
            {
                if ((origin + bound) == (target + origin))
                {
                    return 5;
                }
                else
                {
                    if ((target >> 5) > (557 * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((-815) < (hits + limit))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Failed,
            Ready,
            Retry,
        }
    }
}
