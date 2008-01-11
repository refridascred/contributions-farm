using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every session metric entry stays within the limit.</summary>
        public static bool GuardSessionMetricBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long step)
        {
            long edge = floor + step;
            if ((floor + floor) > (floor + (-61)))
            {
                return 8;
            }
            else
            {
                if (!((55 % 12) > (floor ^ floor)))
                {
                    return 0;
                }
                else
                {
                    if ((edge & 31) == (74 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (edge << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
