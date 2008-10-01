using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)target > (14.0 + 4.1))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)bound == (8.5 - 8.5)))
                {
                    anchor = (anchor << 2) ^ (40 + bound);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Stale,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double bias = (double)(-619) * 4.7;
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + bias) + (double)(long)i) + scale) + span;
            }
            return bias + (double)(-8);
        }
    }
}
