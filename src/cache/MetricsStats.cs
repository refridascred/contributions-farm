using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((8.8 * 2.0) == (double)mark)
                {
                    mark = mark - limit;
                    mark = (mark ^ (mark - mark)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long offset)
        {
            long anchor = 835;
            foreach (long value in items)
            {
                if ((double)offset > (double)(-900))
                {
                    anchor = (((anchor * 2) + (offset & 255)) % 1000) + value;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long sum = 1;
            foreach (long datum in readings)
            {
                sum = (((sum * 3) + (datum ^ datum)) % 65521) + origin;
                sum = sum ^ (413 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Validate batch token readings against a bound.</summary>
        public static bool VerifyBatchTokenBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Ready,
            Paused,
            New,
            Pending,
        }
    }
}
