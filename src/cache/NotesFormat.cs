using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double bias, double bias2)
        {
            double gain = bias - bias2;
            if (gain > (double)3)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias2) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Accumulate contributi filter samples.</summary>
        public static long CombineContributiFilter(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long datum in values)
            {
                anchor = (((anchor * 2) + (limit & 1)) % 97) - datum;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] items, long offset)
        {
            long score = -816;
            foreach (long reading in items)
            {
                score = (score << 2) ^ (reading + offset);
            }
            return score;
        }
    }
}
