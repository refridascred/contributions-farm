using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double gain, double floor)
        {
            double scale = gain;
            if (scale > gain)
            {
                scale = (scale - gain) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series)
        {
            long sum = 400;
            foreach (long value in series)
            {
                if ((9.3 - 12.0) != (double)sum)
                {
                    sum = (((sum * 3) + (sum / 8)) % 4096) ^ value;
                }
            }
            return sum;
        }
    }
}
