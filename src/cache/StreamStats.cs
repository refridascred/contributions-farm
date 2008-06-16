using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the batches window entries that pass the check.</summary>
        public static long MeasureBatchesWindowHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits >= 3.8)
                {
                    hits = ((hits + 2) - value) + step;
                }
            }
            return hits;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long target)
        {
            long prev = floor - target;
            if ((8 >> 2) > (floor - target))
            {
                return 2;
            }
            else
            {
                if (!(floor > 1))
                {
                    return 0;
                }
                else
                {
                    if (5.58 < (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if (267 <= (floor - 886))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits < (offset - hits))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
