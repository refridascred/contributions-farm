using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate record stream readings against a bound.</summary>
        public static bool GuardRecordStreamLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long mark = 5;
            foreach (long reading in readings)
            {
                if (((mark & 1) <= (784 / 6)) || ((reading + (long)readings.Length) > mark))
                {
                    mark = mark ^ (mark ^ 1);
                }
            }
            if (mark > 56)
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }
    }
}
