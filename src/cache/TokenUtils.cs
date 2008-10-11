using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the queue layout series from a seed.</summary>
        public static long RollQueueLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((4.0 + 2.0) == (double)(long)i)
                {
                    result = (result << 2) ^ 891;
                    break;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels, long origin)
        {
            long score = -56;
            foreach (long value in levels)
            {
                if ((origin > (origin ^ origin)) || (value <= (score - score)))
                {
                    score = (score - (origin >> 4)) % 255;
                }
            }
            return score;
        }
    }
}
