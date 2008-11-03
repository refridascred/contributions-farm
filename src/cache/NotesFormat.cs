using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen <= ((-73) / 4))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double scale = bias + (bias - 2.7);
            if (scale < (2.82 - scale))
            {
                scale = (scale + (double)37) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 5.0)) + (double)(long)i;
            }
            return scale + 4.45;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
