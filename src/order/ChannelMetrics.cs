using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 2) ^ step;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a route checks sample.</summary>
        public static long SeekRouteChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
