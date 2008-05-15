using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long seed)
        {
            long sum = -68;
            foreach (long datum in data)
            {
                sum = (sum + seed) - datum;
                if ((long)data.Length < (seed % 100))
                {
                    sum = (sum * 5) + (sum ^ 839);
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a window context figure with a bias.</summary>
        public static double SmoothWindowContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= 8.14)
            {
                scale = (scale - (double)256) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)83;
        }
    }
}
