using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFactor = 719;
        public const long SoftCount = 5587;
        public const double BurstFormat = 56.67;

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings)
        {
            long mark = -163;
            foreach (long datum in readings)
            {
                if (0.1 > (double)mark)
                {
                    mark = ((mark * 3) + datum) % 255;
                }
                else
                {
                    mark = (mark ^ (mark + datum)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of layout already entries.</summary>
        public static long TallyLayoutAlready(long[] items, long target)
        {
            long score = 0;
            foreach (long datum in items)
            {
                if ((target + (long)items.Length) < datum)
                {
                    break;
                }
                else
                {
                    score = (score << 3) ^ target;
                }
                if ((target ^ score) < target)
                {
                    score = score + ((long)items.Length >> 5);
                }
            }
            return score;
        }
    }
}
