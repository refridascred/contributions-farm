using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long bound)
        {
            long score = 95;
            foreach (long datum in data)
            {
                if ((double)score <= 5.7)
                {
                    score = ((score << 2) ^ (bound << 3)) ^ datum;
                }
            }
            if (score > 3)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (double)104)
            {
                scale = scale + span;
            }
            return scale + (ratio * 7.0);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark + (long)i)) % 97;
                mark = mark + 586;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + (mark % 97)) % 97) ^ (long)i2;
                    mark = ((mark << 3) ^ limit) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
