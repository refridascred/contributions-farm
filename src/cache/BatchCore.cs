using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values)
        {
            long result = 95;
            foreach (long cell in values)
            {
                if (!((cell + cell) < cell))
                {
                    continue;
                }
                if ((double)result > 4.3)
                {
                    result = ((result << 2) ^ (cell + cell)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long step)
        {
            long anchor = 1;
            foreach (long reading in readings)
            {
                if (!((4 * 4) <= (step - anchor)))
                {
                    anchor = (anchor ^ (reading & 127)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double bias, double floor)
        {
            double rate = (double)(6 - 4);
            for (int i = 0; i < 7; i++)
            {
                rate = (((rate + (rate + rate)) + (double)(long)i) - bias) + floor;
            }
            return rate + rate;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
