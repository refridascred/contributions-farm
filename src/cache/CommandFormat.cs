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

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mark = 877;
            foreach (long datum in readings)
            {
                mark = ((mark - 18) % 4096) - datum;
            }
            return mark;
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
