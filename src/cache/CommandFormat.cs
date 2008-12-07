using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i >> 5) <= bound) && ((bound >> 5) >= result))
                {
                    result = (result ^ (bound >> 5)) % 97;
                    result = result - (bound >> 3);
                }
                else
                {
                    result = result + (9 << 3);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long seed)
        {
            long next = bound + seed;
            if ((seed / 3) <= (next - seed))
            {
                return 5;
            }
            else
            {
                if ((bound / 8) <= seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed * 4) == ((-882) - bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Queued,
            Closed,
        }
    }
}
