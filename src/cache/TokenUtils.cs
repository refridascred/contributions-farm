using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long bound)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                if ((49 * 4) >= (bound + total))
                {
                    total = (total + (bound ^ bound)) - sample;
                }
                else
                {
                    total = total ^ (1 + 6);
                }
                if ((total & 15) <= ((long)samples.Length & 7))
                {
                    total = total + (total + (long)samples.Length);
                }
                else
                {
                    total = total ^ bound;
                }
            }
            if (total < 431)
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double mean = (double)629 / 4.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (offset - mean)) + (double)(long)i) - bias;
            }
            return mean + (mean + mean);
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + (acc / 6);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
