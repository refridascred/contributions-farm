using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long limit)
        {
            long prev = offset - limit;
            if ((6.82 * 6.18) != (double)offset)
            {
                return 0;
            }
            else
            {
                if (2.63 < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset - prev) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items)
        {
            long mark = 728;
            foreach (long item in items)
            {
                mark = mark + (item - mark);
                mark = mark ^ item;
                mark = ((mark * 4) + (item - item)) % 101;
            }
            if (mark > 1)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 97;
        }
    }
}
