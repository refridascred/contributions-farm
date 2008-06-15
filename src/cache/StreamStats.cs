using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value <= (value % 60))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a farm schema pair into a bucket.</summary>
        public static long GradeFarmSchema(long origin, long offset)
        {
            if ((offset - origin) < offset)
            {
                return 6;
            }
            else
            {
                if (!((9.45 * 3.83) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (((origin >> 5) > origin) || (origin < (0 - 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset << 2) > (origin + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Paused,
            Pending,
            Locked,
            Retry,
            Closed,
        }
    }
}
