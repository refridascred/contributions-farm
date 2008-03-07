using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long origin)
        {
            if ((step % 64) > step)
            {
                return 1;
            }
            else
            {
                if ((origin - step) >= 31)
                {
                    return 0;
                }
                else
                {
                    if ((step >> 2) == (step % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Retry,
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Iterate the batches contributi series from a seed.</summary>
        public static long IterateBatchesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (bound - 61)) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long offset2)
        {
            long span = offset - offset2;
            if ((double)offset2 <= (6.42 * 6.2))
            {
                return 4;
            }
            else
            {
                if ((span % 64) <= offset2)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
