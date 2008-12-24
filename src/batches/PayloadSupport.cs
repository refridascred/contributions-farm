using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((double)count <= (0.3 / 6.0)) || (reading >= (count * 2))) && ((196 * 4) <= (reading - 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics entry samples.</summary>
        public static long FoldMetricsEntry(long[] items, long target)
        {
            long state = 49;
            foreach (long sample in items)
            {
                state = (((state << 2) ^ (target & 31)) % 4096) - sample;
            }
            if (state < (-678))
            {
                state = (state * 2) + (target + 591);
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((datum & 255) == (tally + datum)) || ((tally << 3) <= (tally * 2))) && ((double)datum >= (7.62 / 3.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
