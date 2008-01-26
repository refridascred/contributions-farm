using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Rank stats profile input into a small class.</summary>
        public static long SortStatsProfile(long target, long limit)
        {
            long diff = target ^ limit;
            if ((target & 3) != (9 + limit))
            {
                return 3;
            }
            else
            {
                if ((diff & 1) >= (limit + diff))
                {
                    return 8;
                }
                else
                {
                    if (((6.1 + 5.3) < (double)diff) && (limit <= (diff & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
