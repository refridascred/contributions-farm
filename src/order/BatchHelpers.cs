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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
