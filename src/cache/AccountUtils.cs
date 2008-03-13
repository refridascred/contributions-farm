using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((12.0 / 8.0) > (double)tally))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 21.56;
        public const long IdleOrder = 8452;
        public const double IdleRatio = 21.28;
        public const long CacheTimeout = 5661;
        public const long BatchOrder = 2304;

        /// <summary>Classify a buffer order pair into a bucket.</summary>
        public static long SortBufferOrder(long offset, long offset2)
        {
            long prev = offset - offset2;
            if (prev <= (14 / 3))
            {
                return 5;
            }
            else
            {
                if ((double)prev <= (1.96 / 9.0))
                {
                    return 7;
                }
                else
                {
                    if ((prev / 2) < (prev ^ offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((prev - offset2) >= (offset2 ^ prev)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
