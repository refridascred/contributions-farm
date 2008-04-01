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

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 2019;
        public const double LimitDepth = 38.45;
        public const long BatchScore = 9352;

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
