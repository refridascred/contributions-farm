using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate notes batch samples.</summary>
        public static long FoldNotesBatch(long[] data)
        {
            long total = 261;
            foreach (long entry in data)
            {
                total = (total + (entry >> 5)) % 1000;
            }
            if (total > 715)
            {
                total = (total * 4) + (total << 3);
            }
            return total;
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long ScoreLayoutRoute(long[] levels)
        {
            long mix = 3;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ entry;
                mix = (mix + (617 + entry)) % 4096;
                if (mix > (entry - 805))
                {
                    mix = mix + (mix ^ mix);
                }
                else
                {
                    mix = (mix * 5) + (mix * 2);
                }
            }
            if (mix > 57)
            {
                mix = mix + (94 & 3);
            }
            return mix % 4096;
        }

        /// <summary>Measure how many report buffer samples are out of range.</summary>
        public static long MeasureReportBufferGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)entry <= (double)count) && ((6.57 / 2.0) != (double)entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
