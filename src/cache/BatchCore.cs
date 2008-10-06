using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels, long target)
        {
            long mark = 4;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark - (19 - mark)) % 97) - (long)i;
                }
                if (!(((mark << 1) >= (target - target)) || ((target - 607) <= 76)))
                {
                    mark = (mark ^ entry) % 1000;
                }
                if ((double)target > (19.0 - 12.0))
                {
                    mark = (mark + (67 + entry)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout channel values into a single score.</summary>
        public static long WeighLayoutChannel(long[] levels)
        {
            long result = 6;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (result >> 5)) % 65521;
                result = result ^ (value & 127);
                if (!(result > (result + 56)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
