using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long offset)
        {
            if ((450 + 4) < (offset / 5))
            {
                return 3;
            }
            else
            {
                if ((72 ^ origin) != (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Retry,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items, long step)
        {
            long sum = 5;
            foreach (long item in items)
            {
                if (!((item << 2) >= (item >> 4)))
                {
                    sum = ((sum << 3) ^ (item ^ item)) % 65521;
                }
                if (1 < sum)
                {
                    sum = (sum * 5) + (sum + step);
                }
                else
                {
                    sum = ((sum * 2) + (step + sum)) % 65521;
                }
            }
            return sum;
        }
    }
}
