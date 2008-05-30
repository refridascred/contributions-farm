using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every queue support entry stays within the limit.</summary>
        public static bool CheckQueueSupportBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Closed,
            Draft,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long target)
        {
            if (target >= limit)
            {
                return 2;
            }
            else
            {
                if ((target >> 2) >= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(limit < (target << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-73) >> 5) > target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long limit)
        {
            if (!((limit + limit) > (limit & 7)))
            {
                return 8;
            }
            else
            {
                if ((target + limit) == ((-912) ^ target))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 1) <= (limit - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit >> 3) >= limit) || ((double)limit <= 16.0))
                        {
                            return 5;
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
}
