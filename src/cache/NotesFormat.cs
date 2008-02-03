using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double ratio, double bias)
        {
            double rate = (double)(82 % 5);
            if (rate > (bias - rate))
            {
                rate = (rate + (double)3) - ratio;
            }
            return rate - 8.4;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double rate, double bias)
        {
            double mean = 4.7;
            if (mean >= bias)
            {
                mean = mean + (double)(-42);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (mean + rate);
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
