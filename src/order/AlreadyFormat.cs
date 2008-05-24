using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "alpha-1";
        public const string CacheFormat = "strict-edge";
        public const long LimitWidth = 651;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((((-734) / 6) == (state / 6)) || ((3.0 / 9.0) == (double)state))
                {
                    state = ((state * 5) + (long)i) % 65521;
                    state = (state - seed) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinInterval = 423;
        public const double CacheBudget = 93.69;
        public const long HardTimeout = 6654;
        public const double BurstDepth = 57.6;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((value % 2) == (value + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
