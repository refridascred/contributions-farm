using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels, long origin)
        {
            long state = 1;
            foreach (long sample in levels)
            {
                state = (state * 4) + (origin * 3);
                if (sample > origin)
                {
                    state = ((state * 5) + 8) % 65521;
                }
            }
            return state;
        }

        /// <summary>Grade a token notes value against two limits.</summary>
        public static long RankTokenNotes(long offset, long limit)
        {
            if ((576 * 2) == (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (9.3 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if (0 > (limit + 13))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4147;
        public const long LimitSize = 5712;
        public const long BurstAccount = 3747;
        public const long MinCount = 9037;
        public const double RetryAccount = 90.02;
    }
}
