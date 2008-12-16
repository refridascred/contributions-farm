using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches == (double)datum)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long seed)
        {
            long edge = origin - seed;
            if (((seed + origin) < (edge % 12)) || ((origin >> 1) <= (seed >> 3)))
            {
                return 7;
            }
            else
            {
                if (((double)seed <= (double)origin) && ((double)seed == (6.0 - 5.4)))
                {
                    return 2;
                }
                else
                {
                    if (!(origin < (origin >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge ^ edge) >= (seed + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
