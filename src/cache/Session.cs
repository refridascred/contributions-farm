using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= gain)
            {
                gain2 = gain2 + (bias + gain);
            }
            else
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 + (bias - gain2);
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values, long offset)
        {
            long state = -63;
            foreach (long cell in values)
            {
                if (0 > (state >> 5))
                {
                    state = (((state << 2) ^ (8 * 4)) ^ cell) + offset;
                }
            }
            if (state < 651)
            {
                state = (state ^ 53) % 97;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of metrics tools entries.</summary>
        public static long CombineMetricsTools(long[] values)
        {
            long anchor = 30;
            foreach (long entry in values)
            {
                if ((double)anchor < 3.0)
                {
                    anchor = ((anchor * 5) + entry) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ (entry % 97);
                }
                if ((194 / 7) > anchor)
                {
                    break;
                }
            }
            if (anchor > 631)
            {
                anchor = anchor + anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] samples, long bound)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = (((acc + ((long)samples.Length << 1)) % 97) ^ entry) + bound;
            }
            return acc;
        }
    }
}
