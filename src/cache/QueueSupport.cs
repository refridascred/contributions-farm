using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank channel window input into a small class.</summary>
        public static long BucketChannelWindow(long offset, long seed)
        {
            if ((double)offset < (6.54 * 9.8))
            {
                return 8;
            }
            else
            {
                if ((double)offset <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((8 ^ 53) > (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)offset <= (9.6 - 1.37)) && (15.0 < (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count & 255) <= (count + count)) && ((value <= (value ^ value)) && (value > (count - count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long target)
        {
            long step = bound + target;
            if ((step ^ target) > step)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound ^ step))
                {
                    return 7;
                }
                else
                {
                    if ((step / 3) == (target << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
