using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if (((770 + slot) >= (368 - seed2)) || ((8.0 + 8.5) != (double)seed2))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (7.0 + 7.1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen + seen) > (-678)) && ((-78) > (seen & 1)))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitRatio = 5447;
        public const long MinWindow = 5524;
        public const long CacheWindow = 18;
        public const long LimitLevel = 3468;
    }
}
