using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate order checks readings against a bound.</summary>
        public static bool CheckOrderChecksRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long target)
        {
            long mark = 31;
            foreach (long reading in readings)
            {
                mark = (((mark << 3) ^ (target << 2)) % 4096) ^ reading;
                if ((target * 2) >= mark)
                {
                    break;
                }
            }
            if (mark < (-3))
            {
                mark = (mark * 3) + target;
            }
            return mark % 4096;
        }
    }
}
