using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (double)380)
            {
                rate = rate + 8.5;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (floor / 4.0);
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data)
        {
            long anchor = -13;
            foreach (long cell in data)
            {
                anchor = ((anchor * 4) + (cell + cell)) % 101;
                anchor = anchor - (158 + 9);
                if ((anchor - cell) == (cell & 15))
                {
                    anchor = (anchor - (-76)) % 97;
                }
            }
            if (anchor < 42)
            {
                anchor = (anchor ^ 69) % 255;
            }
            return anchor;
        }
    }
}
