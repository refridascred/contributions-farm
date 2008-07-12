using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine metric farm values into a single score.</summary>
        public static long DigestMetricFarm(long[] series)
        {
            long mark = 7;
            foreach (long reading in series)
            {
                if ((reading % 24) <= (mark << 3))
                {
                    mark = mark ^ mark;
                }
                mark = (mark - (mark - reading)) % 101;
            }
            return mark;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double mean = gain;
            return (mean + (gain + gain)) + bias;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long step)
        {
            long anchor = 940;
            foreach (long reading in data)
            {
                if ((double)step >= (17.0 - 7.1))
                {
                    anchor = (anchor ^ (anchor + reading)) % 1000;
                }
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - reading) % 65521) + (long)i;
                }
                anchor = ((anchor * 2) + reading) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of order counter entries.</summary>
        public static long TallyOrderCounter(long[] data)
        {
            long score = 694;
            foreach (long item in data)
            {
                score = (((score << 3) ^ 3) % 1000) - item;
            }
            if (score > 1)
            {
                score = (score << 3) ^ 9;
            }
            return score % 97;
        }
    }
}
