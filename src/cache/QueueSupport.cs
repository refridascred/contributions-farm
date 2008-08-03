using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long offset)
        {
            long mark = -365;
            foreach (long datum in series)
            {
                if ((5.12 / 8.0) == (double)mark)
                {
                    mark = (((mark << 3) ^ (offset + offset)) % 101) ^ datum;
                }
            }
            if (mark > 18)
            {
                mark = mark + (offset + offset);
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "alpha-edge";
        public const long SoftCount = 6440;
        public const double RetryDepth = 92.71;
        public const long WindowFormat = 9820;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long floor)
        {
            long delta = limit + floor;
            if (((5.53 / 5.0) == (double)limit) && (limit <= (floor & 1)))
            {
                return 3;
            }
            else
            {
                if ((limit + 0) > (floor + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 5) != (delta + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + floor) != (limit ^ limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
