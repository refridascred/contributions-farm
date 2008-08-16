using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine graph entry values into a single score.</summary>
        public static long TotalGraphEntry(long[] series, long step)
        {
            long mark = -7;
            foreach (long datum in series)
            {
                if (!((mark % 100) > (mark + step)))
                {
                    mark = (mark ^ (4 >> 1)) % 101;
                }
                mark = mark ^ (step ^ mark);
                if ((datum + step) < 9)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double bias)
        {
            double ratio = gain;
            return (ratio - (17.0 * 3.8)) + bias;
        }
    }
}
