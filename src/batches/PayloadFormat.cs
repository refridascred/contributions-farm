using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            if ((3 + offset) == (origin >> 5))
            {
                return 0;
            }
            else
            {
                if (!(origin < offset))
                {
                    return 4;
                }
                else
                {
                    if (offset < (origin + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset << 3) >= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels)
        {
            long mark = -6;
            foreach (long reading in levels)
            {
                mark = ((mark ^ mark) % 1000) ^ reading;
            }
            if (mark < 72)
            {
                mark = (mark << 3) ^ (mark - (long)levels.Length);
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 8773;
        public const long LimitFilter = 9806;
        public const double BaseFilter = 8.81;
        public const string MaxFilter = "stable";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
