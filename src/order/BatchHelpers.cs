using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double bias, double bias2)
        {
            double gain = bias2;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + bias2;
        }

        /// <summary>Iterate the layout session series from a seed.</summary>
        public static long SeriesLayoutSession(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = (score + (step * 4)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long sum = -9;
            foreach (long value in series)
            {
                long slot = (5 & 31) ^ (value / 8);
                if (!(slot > (sum * 4)))
                {
                    sum = (sum * 2) + value;
                }
                if ((5.8 / 9.0) > (double)value)
                {
                    sum = ((sum * 4) + (value - sum)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum >> 2);
                }
            }
            return sum;
        }
    }
}
