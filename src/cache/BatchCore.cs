using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits <= (667 / 3))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long CountStreamProfileOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((285 % 64) <= (value / 3))
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long limit)
        {
            long diff = seed ^ limit;
            if (((-804) - seed) == (seed ^ diff))
            {
                return 7;
            }
            else
            {
                if (limit >= (527 + diff))
                {
                    return 2;
                }
                else
                {
                    if (!(limit >= diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed - limit) == (limit + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Pending,
            Queued,
        }
    }
}
