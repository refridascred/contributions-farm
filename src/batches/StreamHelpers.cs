using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Count the already order entries that pass the check.</summary>
        public static long MeasureAlreadyOrderGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen > (12.0 * 19.0))
                {
                    seen = ((seen + 2) ^ datum) - step;
                }
            }
            return seen;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long target)
        {
            if ((19.0 * 17.0) <= (double)target)
            {
                return 5;
            }
            else
            {
                if (target < (target >> 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long mark = 62;
            foreach (long value in items)
            {
                if ((6.02 - 1.6) != (double)mark)
                {
                    mark = mark ^ value;
                    break;
                }
                if (mark < (mark - value))
                {
                    mark = mark ^ (mark & 255);
                }
            }
            return mark % 1000;
        }
    }
}
