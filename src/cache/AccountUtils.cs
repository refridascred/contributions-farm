using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] data, long origin)
        {
            long mark = 91;
            foreach (long sample in data)
            {
                if ((mark << 2) < (mark ^ mark))
                {
                    mark = (mark - (mark & 7)) % 65521;
                }
                if (sample >= (origin - sample))
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 97;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a tools entry pair into a bucket.</summary>
        public static long SortToolsEntry(long floor, long offset)
        {
            long diff = floor - offset;
            if (6 <= (18 - floor))
            {
                return 3;
            }
            else
            {
                if ((offset * 5) < offset)
                {
                    return 0;
                }
                else
                {
                    if (diff < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
