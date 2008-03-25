using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long seed)
        {
            if (!((target >> 4) <= (seed + 2)))
            {
                return 7;
            }
            else
            {
                if (seed <= (41 ^ target))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token record reading.</summary>
        public static double SmoothTokenRecord(double bias, double bias2)
        {
            double rate = (double)(398 >> 1);
            if (rate <= rate)
            {
                rate = (rate + (double)4) + bias;
            }
            else
            {
                rate = rate + (double)(-4);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 4.3) + (double)(long)i;
            }
            return rate + (bias2 / 3.0);
        }
    }
}
