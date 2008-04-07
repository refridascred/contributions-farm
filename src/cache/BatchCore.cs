using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "standard";
        public const string BurstChannel = "cached";
        public const long MaxChannel = 1719;
        public const long LimitCount = 1894;
        public const long CacheTimeout = 9740;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (limit >= diff)
            {
                return 4;
            }
            else
            {
                if (((double)limit >= 8.58) || ((1 & 255) >= (bound % 60)))
                {
                    return 3;
                }
                else
                {
                    if (((-583) / 6) < (bound + diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)diff < (7.4 - 6.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((offset / 2) < offset) || ((offset % 60) < offset))
                {
                    mark = mark ^ offset;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
