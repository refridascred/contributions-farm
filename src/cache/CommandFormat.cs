using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen - item) >= item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((double)mark < (double)bound) || ((double)mark < 6.6))
                {
                    mark = ((mark * 5) + (bound + bound)) % 255;
                    break;
                }
                else
                {
                    mark = (mark ^ bound) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
