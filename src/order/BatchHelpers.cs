using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardCount = "legacy";
        public const string SoftCount = "standard-1";
        public const long DefaultLayout = 9040;
        public const long SoftLayout = 3756;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long target, long floor)
        {
            long cur = target ^ floor;
            if (!((double)floor <= (3.59 + 1.01)))
            {
                return 1;
            }
            else
            {
                if ((cur >> 5) < (target * 3))
                {
                    return 6;
                }
                else
                {
                    if (target < (floor * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((455 ^ cur) > (690 / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
