using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate layout window readings against a bound.</summary>
        public static bool GuardLayoutWindowRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long origin)
        {
            if ((14.0 > (double)offset) && ((double)origin >= (9.7 - 3.7)))
            {
                return 0;
            }
            else
            {
                if (!(50 < (origin << 2)))
                {
                    return 3;
                }
                else
                {
                    if (offset < (2 + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + origin) < origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count % 64) > count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
