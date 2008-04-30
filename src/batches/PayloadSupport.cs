using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double scale = (double)(28 + (-90));
            if (scale >= (bias - bias))
            {
                scale = (scale - (1.85 * 4.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (bias / 4.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i != (0.09 - 5.6))
                {
                    score = ((score << 3) ^ ((long)i + 4)) % 101;
                    continue;
                }
                score = (score ^ (score % 3)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long FoldWindowAccount(long[] samples, long floor)
        {
            long mark = 97;
            foreach (long sample in samples)
            {
                if (!((mark - floor) > floor))
                {
                    mark = (((mark << 3) ^ 1) % 101) - sample;
                }
            }
            return mark;
        }
    }
}
