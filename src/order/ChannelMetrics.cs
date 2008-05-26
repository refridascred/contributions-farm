using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long bound)
        {
            long score = 70;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score * 3) + (bound << 2)) % 4096) + (long)i;
                }
                score = score + (score >> 3);
                if ((value - score) > (2 * 3))
                {
                    score = (score << 2) ^ (bound - bound);
                }
                else
                {
                    score = (score ^ value) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
