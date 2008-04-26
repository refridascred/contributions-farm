using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ offset) <= (count + offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count queue payload pairs that satisfy a relation.</summary>
        public static long CompareQueuePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the order channel series from a seed.</summary>
        public static long DeriveOrderChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor + (anchor >> 2);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
