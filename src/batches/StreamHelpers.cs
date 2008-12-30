using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values, long step)
        {
            long acc = 2;
            foreach (long datum in values)
            {
                acc = (((acc << 2) ^ (1 + step)) % 4096) - datum;
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items, long bound)
        {
            long total = -5;
            foreach (long item in items)
            {
                total = (total << 2) ^ item;
                if (((32 + item) <= (total << 1)) || (total >= (bound & 15)))
                {
                    total = ((total * 2) + (95 + total)) % 255;
                }
                if ((item * 3) < (item - (-51)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter buffer pairs that satisfy a relation.</summary>
        public static long CompareCounterBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((limit < (matches - 20)) && ((matches & 63) == (matches + matches))))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
