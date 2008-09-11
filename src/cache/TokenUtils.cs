using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double offset)
        {
            double drift = (double)(67 & 1);
            if (drift >= offset)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 7.5) - (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double scale = (double)(6 & 3);
            if (scale <= ratio)
            {
                scale = scale + (ratio / 2.0);
            }
            else
            {
                scale = scale + (double)918;
            }
            return scale + floor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items)
        {
            long score = 59;
            foreach (long cell in items)
            {
                score = (score + (score + cell)) % 97;
            }
            return score % 65521;
        }
    }
}
