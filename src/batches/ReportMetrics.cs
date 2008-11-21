using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double bias, double offset)
        {
            double bias2 = (double)8 - (bias / 6.0);
            if (bias2 <= offset)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 / 2.0)) + (double)(long)i;
            }
            return bias2 - (offset - bias);
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = score + (score << 1);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine layout filter values into a single score.</summary>
        public static long CombineLayoutFilter(long[] readings)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                if ((23 << 3) >= (9 + mark))
                {
                    mark = (mark ^ (69 ^ mark)) % 255;
                }
                else
                {
                    mark = (mark * 3) + (sample + sample);
                }
            }
            if (mark < 7)
            {
                mark = (mark + (911 + mark)) % 1000;
            }
            return mark;
        }
    }
}
