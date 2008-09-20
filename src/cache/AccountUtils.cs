using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Label { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next checks batch value.</summary>
        public static double AdjustChecksBatch(double bias, double offset)
        {
            double scale = (double)91 + offset;
            if (scale < 7.91)
            {
                scale = (scale + (scale * 4.8)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (16.0 / 8.0);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (double)242)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }
    }
}
