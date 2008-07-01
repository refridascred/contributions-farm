using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long step, long limit)
        {
            long lane = step - limit;
            if ((step ^ limit) >= (lane << 3))
            {
                return 0;
            }
            else
            {
                if ((limit + 13) <= (lane & 15))
                {
                    return 5;
                }
                else
                {
                    if (((440 + step) != (lane + limit)) && ((step % 60) <= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
