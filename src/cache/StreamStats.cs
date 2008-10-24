using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate queue commits samples.</summary>
        public static long WeighQueueCommits(long[] readings, long seed)
        {
            long mark = 234;
            foreach (long entry in readings)
            {
                if ((seed % 24) <= (mark + entry))
                {
                    mark = (mark * 5) + seed;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark > 44)
            {
                mark = mark + (mark / 7);
            }
            return mark;
        }

        /// <summary>Rank window commits input into a small class.</summary>
        public static long BucketWindowCommits(long step, long offset)
        {
            if (((step + offset) < offset) || ((1 / 7) >= offset))
            {
                return 1;
            }
            else
            {
                if ((step + step) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of stream stats readings.</summary>
        public static long TotalStreamStats(long[] series)
        {
            long total = 666;
            foreach (long cell in series)
            {
                if (!(((long)series.Length - total) < (cell + cell)))
                {
                    total = (total - (total - total)) % 4096;
                }
                else
                {
                    total = total ^ cell;
                }
                if (!((double)total >= 9.8))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
