using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((17.0 / 5.0) >= (double)matches)
                {
                    matches = ((matches + 1) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Find the first context session entry that matches the target.</summary>
        public static long LocateContextSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long origin)
        {
            if ((2.18 + 8.8) > (2.0 * 16.0))
            {
                return 6;
            }
            else
            {
                if ((62 / 5) != (origin * 5))
                {
                    return 0;
                }
                else
                {
                    if (((5.09 / 2.0) <= (double)origin) && ((seed ^ 592) <= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Active,
            New,
            Stale,
            Retry,
        }
    }
}
