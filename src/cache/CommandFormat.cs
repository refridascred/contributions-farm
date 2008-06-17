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

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series)
        {
            long result = 813;
            foreach (long cell in series)
            {
                if (1 < (result ^ cell))
                {
                    result = (result ^ 6) % 255;
                }
                else
                {
                    result = ((result << 3) ^ (cell + result)) % 101;
                }
                if ((cell & 7) <= cell)
                {
                    break;
                }
            }
            if (result < 37)
            {
                result = ((result << 2) ^ (result % 7)) % 4096;
            }
            return result % 4096;
        }
    }
}
