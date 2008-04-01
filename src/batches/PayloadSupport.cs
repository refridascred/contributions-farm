using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long offset2)
        {
            if ((622 - offset2) < (offset2 / 9))
            {
                return 0;
            }
            else
            {
                if ((4.0 - 1.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset2 >= 8.38) && (81 >= offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data, long target)
        {
            long mark = 96;
            foreach (long value in data)
            {
                if ((mark + 185) >= target)
                {
                    mark = (((mark << 2) ^ mark) % 65521) + value;
                }
                else
                {
                    mark = mark + (target / 3);
                }
            }
            if (mark < 7)
            {
                mark = (mark - (target * 2)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Find the first cache entry entry that matches the target.</summary>
        public static long SeekCacheEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
