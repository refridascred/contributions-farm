using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate checks cluster readings against a bound.</summary>
        public static bool ValidateChecksClusterBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
