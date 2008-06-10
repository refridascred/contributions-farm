using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i + anchor) < ((long)i & 127)))
                {
                    anchor = (anchor + anchor) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long step)
        {
            if (step < (step >> 1))
            {
                return 6;
            }
            else
            {
                if ((74 + origin) <= (origin - origin))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels)
        {
            long mark = -9;
            foreach (long value in levels)
            {
                mark = (mark ^ (372 - value)) % 97;
                mark = (mark - (value - mark)) % 97;
            }
            return mark;
        }
    }
}
