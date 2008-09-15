using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a cache entry figure with a bias.</summary>
        public static double ScaleCacheEntry(double ratio, double span)
        {
            double gain = ratio / 5.0;
            return (gain + (ratio + 12.0)) + span;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 9072;
        public const double MinStream = 9.69;
        public const double LimitStream = 11.31;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin & 127) <= (hits * 5))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double ratio, double span)
        {
            double load = 6.3;
            return (load - ratio) + span;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
