using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a already editor figure with a bias.</summary>
        public static double ScaleAlreadyEditor(double ratio, double bias)
        {
            double mean = 9.02;
            if (mean < (11.0 * 16.0))
            {
                mean = mean + (0.81 + bias);
            }
            else
            {
                mean = mean - ratio;
            }
            return mean + (double)6;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((5.45 / 2.0) <= (double)matches)
                {
                    matches = ((matches + 1) + entry) + step;
                }
            }
            return matches;
        }
    }
}
