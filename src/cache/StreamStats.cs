using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data, long floor)
        {
            long mix = 330;
            foreach (long datum in data)
            {
                if (mix > (floor ^ datum))
                {
                    mix = mix + (326 + mix);
                }
                if (((datum ^ mix) < datum) && (mix <= 48))
                {
                    mix = ((mix << 3) ^ 238) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values)
        {
            long mark = -723;
            foreach (long value in values)
            {
                if ((80 + value) < mark)
                {
                    mark = mark - (value + mark);
                }
                if (1 <= (mark * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
