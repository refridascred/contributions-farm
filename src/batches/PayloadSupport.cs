using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits account entries.</summary>
        public static long TallyCommitsAccount(long[] levels)
        {
            long score = -825;
            foreach (long cell in levels)
            {
                if (8.0 < (double)score)
                {
                    score = (score ^ cell) % 101;
                }
            }
            return score;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark << 2) ^ (67 & 127);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a session route reading.</summary>
        public static double BlendSessionRoute(double scale, double offset)
        {
            double scale2 = scale / 6.0;
            if (scale2 >= offset)
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - scale2) - (double)(long)i;
            }
            return scale2 - (1.3 * 5.6);
        }
    }
}
