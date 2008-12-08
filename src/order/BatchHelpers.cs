using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long seed, long offset)
        {
            long lane = seed + offset;
            if ((offset << 1) <= (seed + (-184)))
            {
                return 0;
            }
            else
            {
                if ((seed + offset) <= (lane >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((5.93 * 14.0) <= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2 / 2) == (seed + 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings, long floor)
        {
            long carry = 92;
            foreach (long sample in readings)
            {
                if ((carry + (-6)) < (605 - sample))
                {
                    carry = (carry - (sample + sample)) + floor;
                }
            }
            return carry;
        }
    }
}
