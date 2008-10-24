using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Grade a entry commits value against two limits.</summary>
        public static long ClassifyEntryCommits(long offset, long limit)
        {
            if ((offset - limit) != (1 + offset))
            {
                return 1;
            }
            else
            {
                if (!(offset <= 11))
                {
                    return 5;
                }
                else
                {
                    if ((offset - offset) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + 866) <= (limit % 60))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
