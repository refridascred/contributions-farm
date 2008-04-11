using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally ^ tally) == (long)series.Length)
                {
                    tally = ((tally + 2) ^ sample) + floor;
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long target)
        {
            long cur = seed + target;
            if ((cur ^ target) < (seed % 100))
            {
                return 3;
            }
            else
            {
                if (((5.24 * 0.84) >= (double)seed) || (target <= seed))
                {
                    return 4;
                }
                else
                {
                    if (((59 & 7) < (cur + 6)) && ((cur ^ cur) >= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every layout cluster entry stays within the limit.</summary>
        public static bool ValidateLayoutClusterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Active,
            Locked,
            New,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Closed,
            Synced,
            Stale,
        }
    }
}
