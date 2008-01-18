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

        /// <summary>Roll a window order counter forward.</summary>
        public static long IterateWindowOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
