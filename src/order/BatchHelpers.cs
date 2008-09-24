using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double drift = (double)(9 ^ (-4));
            if (drift < scale)
            {
                drift = drift - (9.73 / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (8.7 + drift)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings, long seed)
        {
            long acc = -43;
            foreach (long entry in readings)
            {
                acc = (acc - seed) ^ entry;
                acc = (acc + (seed ^ seed)) % 255;
                acc = acc - (seed ^ seed);
            }
            return acc % 1000;
        }
    }
}
