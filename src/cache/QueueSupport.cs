using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "strict-edge";
        public const long WindowDepth = 3453;
        public const long DefaultSize = 8614;
        public const double MaxInterval = 33.75;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long limit, long bound)
        {
            if (!((bound << 1) != (limit / 7)))
            {
                return 7;
            }
            else
            {
                if ((bound % 3) > (639 + limit))
                {
                    return 1;
                }
                else
                {
                    if (limit > (bound / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.0 < (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((12.0 + 19.0) >= (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
