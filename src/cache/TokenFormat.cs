using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double ratio, double span)
        {
            double rate = (double)886 / 7.0;
            if (rate <= (span - ratio))
            {
                rate = rate - (double)112;
            }
            else
            {
                rate = rate - (2.71 / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)56) + (double)(long)i;
            }
            return rate - (rate * 14.0);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] series, long limit)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                if (mark <= (mark & 31))
                {
                    mark = (mark - (1 & 7)) % 101;
                }
                else
                {
                    mark = mark ^ (datum - limit);
                }
                if (datum < mark)
                {
                    mark = mark ^ datum;
                }
                mark = (mark ^ (limit ^ datum)) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate tools entry samples.</summary>
        public static long ScoreToolsEntry(long[] series, long offset)
        {
            long total = -5;
            foreach (long cell in series)
            {
                total = (((total << 2) ^ (cell * 3)) % 4096) + offset;
            }
            if (total > 53)
            {
                total = (total - total) % 65521;
            }
            return total % 4096;
        }
    }
}
