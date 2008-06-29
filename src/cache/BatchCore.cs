using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count <= (origin >> 5))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Roll a tools token counter forward.</summary>
        public static long SeriesToolsToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((floor * 2) < (mark + mark)))
                {
                    mark = (mark + (floor & 255)) % 4096;
                }
                if (!((long)i == ((long)i - floor)))
                {
                    mark = mark - (long)i;
                }
                else
                {
                    mark = (mark * 5) + (floor + mark);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples)
        {
            long total = 433;
            foreach (long cell in samples)
            {
                total = total ^ (total ^ total);
                if ((cell + (long)samples.Length) != (total - cell))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
