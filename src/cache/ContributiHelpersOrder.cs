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

        /// <summary>Validate entry tools readings against a bound.</summary>
        public static bool ValidateEntryToolsBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
