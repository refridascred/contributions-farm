using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally % 60) > reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-9) << 3) > (count * 4))
                {
                    count = ((count + 3) + cell) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long seed, long floor)
        {
            long bound = seed - floor;
            if (93 < (bound + bound))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((bound + floor) <= (seed + seed))
                    {
                        return 5;
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
