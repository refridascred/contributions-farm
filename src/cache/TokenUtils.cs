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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double bias)
        {
            double ratio = gain;
            return (ratio - (17.0 * 3.8)) + bias;
        }
    }
}
