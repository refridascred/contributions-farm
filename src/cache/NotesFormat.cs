using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account route entries.</summary>
        public static long WeighAccountRoute(long[] readings, long bound)
        {
            long anchor = 69;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor * 3) + reading) - (long)i;
                }
                if (((anchor % 2) == (anchor ^ reading)) && (6.77 >= (double)anchor))
                {
                    anchor = anchor ^ (reading % 7);
                }
                else
                {
                    anchor = (anchor - bound) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (bias2 * 9.0))
            {
                weight = (weight - (double)54) + bias;
            }
            return weight + bias2;
        }
    }
}
