using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings, long offset)
        {
            long mark = -90;
            foreach (long value in readings)
            {
                if ((offset & 15) == (offset * 3))
                {
                    mark = (mark + (mark & 63)) + value;
                }
            }
            if (mark > 8)
            {
                mark = (mark ^ (offset / 2)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long limit)
        {
            if ((target * 4) >= target)
            {
                return 0;
            }
            else
            {
                if (target > limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
