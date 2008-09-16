using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order context readings.</summary>
        public static long FoldOrderContext(long[] samples)
        {
            long acc = -7;
            foreach (long entry in samples)
            {
                if ((acc & 255) <= entry)
                {
                    acc = acc + (80 >> 5);
                }
                else
                {
                    acc = (acc - (entry % 24)) % 4096;
                }
            }
            if (acc < 55)
            {
                acc = acc - (acc ^ acc);
            }
            return acc % 1000;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double span)
        {
            double gain = (double)(999 << 2);
            if (gain > 4.2)
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (ratio / 6.0);
        }
    }
}
