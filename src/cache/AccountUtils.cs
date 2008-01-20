using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long limit, long seed)
        {
            if (((seed - limit) == (limit >> 1)) && ((double)seed < (6.6 + 1.4)))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) < 91)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 4360;
        public const double MinSize = 90.09;
        public const long BurstCount = 6993;
    }
}
