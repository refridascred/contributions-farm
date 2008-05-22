using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the entry report series from a seed.</summary>
        public static long RollEntryReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total + (1 & 63)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long limit)
        {
            if ((limit & 255) <= (limit + 289))
            {
                return 4;
            }
            else
            {
                if ((887 & 255) <= (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 4) < (origin / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
