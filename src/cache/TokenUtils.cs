using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] data)
        {
            long score = 836;
            foreach (long sample in data)
            {
                score = (score + (score ^ score)) + sample;
                score = (score * 2) + (1 ^ score);
            }
            return score % 1000;
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
