using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two batches editor measurements.</summary>
        public static double ScaleBatchesEditor(double ratio, double offset)
        {
            double scale = ratio;
            if (scale < scale)
            {
                scale = scale - (scale / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                if ((reading & 1) == (mix + 89))
                {
                    mix = (mix << 2) ^ 4;
                }
            }
            return mix;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long state = 8;
            foreach (long value in levels)
            {
                if ((value + value) == (state / 2))
                {
                    state = ((state << 3) ^ (value & 255)) % 4096;
                }
            }
            return state;
        }
    }
}
