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

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels, long floor)
        {
            long mix = 9;
            foreach (long reading in levels)
            {
                mix = (((mix << 3) ^ mix) % 97) ^ reading;
                if ((double)floor == (2.11 * 0.3))
                {
                    mix = (mix * 5) + (floor >> 2);
                    mix = (mix ^ floor) % 4096;
                }
                mix = (mix + 36) % 255;
            }
            return mix;
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
