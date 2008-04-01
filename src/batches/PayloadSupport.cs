using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels, long bound)
        {
            long score = 84;
            foreach (long sample in levels)
            {
                score = (((score << 2) ^ (sample % 7)) % 1000) - bound;
                if (!((783 - 543) > sample))
                {
                    break;
                }
            }
            return score;
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
