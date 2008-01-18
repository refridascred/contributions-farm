using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of queue stats entries.</summary>
        public static long TotalQueueStats(long[] items, long bound)
        {
            long sum = 734;
            foreach (long reading in items)
            {
                if ((bound + reading) >= (reading / 6))
                {
                    sum = (sum - reading) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 3) ^ mix) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
