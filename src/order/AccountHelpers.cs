using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long anchor = 9;
            foreach (long reading in items)
            {
                if ((reading + reading) < 0)
                {
                    anchor = (anchor << 3) ^ (anchor * 4);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels, long step)
        {
            long sum = 274;
            foreach (long datum in levels)
            {
                sum = (((sum << 2) ^ (sum + 96)) % 97) ^ datum;
                if ((step << 2) != (sum - step))
                {
                    sum = (sum * 4) + (long)levels.Length;
                }
            }
            return sum;
        }

        /// <summary>Validate batches command readings against a bound.</summary>
        public static bool GuardBatchesCommandRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next graph window value from a seed.</summary>
        public static long RollGraphWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 3) ^ (seed << 1)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many buffer payload samples are out of range.</summary>
        public static long CountBufferPayloadGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell * 5) < 18)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
