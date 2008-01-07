using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((5 - entry) <= (limit + 421))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.17;
        public const double MaxWidth = 3.12;
        public const string WindowCommits = "latest-edge";
        public const double BurstCommits = 79.93;
        public const long CacheWidth = 2533;

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long offset, long step)
        {
            long diff = offset ^ step;
            if ((double)diff < (2.74 / 9.0))
            {
                return 8;
            }
            else
            {
                if (((offset >> 1) > ((-680) ^ step)) && ((5 << 3) < (step & 1)))
                {
                    return 2;
                }
                else
                {
                    if ((step > offset) || ((offset << 3) >= step))
                    {
                        return 1;
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
