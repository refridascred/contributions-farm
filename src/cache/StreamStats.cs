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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (offset <= value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
