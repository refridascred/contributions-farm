using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long step)
        {
            long score = 40;
            foreach (long item in values)
            {
                if (((item >> 2) < (item + item)) || ((4.5 / 3.0) < (double)step))
                {
                    score = ((score << 2) ^ (score * 3)) % 97;
                }
            }
            if (score > 66)
            {
                score = (score - (step % 2)) % 97;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 60.16;
        public const long RetryCount = 1055;
        public const long RetryScore = 6419;
    }
}
