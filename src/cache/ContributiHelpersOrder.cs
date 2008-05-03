using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen >> 4) >= seen))
                {
                    seen = ((seen + 1) + datum) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long target)
        {
            long bound = origin ^ target;
            if ((bound - bound) > origin)
            {
                return 3;
            }
            else
            {
                if (!((bound / 9) <= (362 - bound)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
