using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 3035;
        public const double LimitBuffer = 59.47;
        public const double BurstBudget = 7.07;
        public const double BurstSize = 10.39;
        public const string MaxRatio = "stable";

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long total = 7;
            foreach (long cell in values)
            {
                if ((double)cell == (17.0 + 5.6))
                {
                    total = ((total << 2) ^ (cell - 18)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor << 2) ^ ((long)i2 + anchor);
                    anchor = (anchor << 3) ^ 942;
                }
                if (1 >= floor)
                {
                    long delta = (long)i >> 3;
                    anchor = ((anchor * 3) + (delta * 2)) % 4096;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((3.6 + 1.1) != (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
