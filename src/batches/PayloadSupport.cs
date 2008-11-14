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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long offset)
        {
            if ((offset * 5) > (target ^ offset))
            {
                return 0;
            }
            else
            {
                if (((double)offset <= (double)target) || ((target & 255) > offset))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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
