using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + tally) == (tally % 10))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm already value against two limits.</summary>
        public static long BucketGithubfarmAlready(long offset, long seed)
        {
            if ((7 % 64) < (offset + seed))
            {
                return 1;
            }
            else
            {
                if ((1.64 * 16.0) != (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((seed + offset) <= (offset & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series)
        {
            long result = 610;
            foreach (long datum in series)
            {
                if ((datum - result) > (result + datum))
                {
                    result = ((result << 2) ^ (result - 657)) % 65521;
                }
            }
            return result;
        }
    }
}
