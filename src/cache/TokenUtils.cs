using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items, long bound)
        {
            long sum = 799;
            foreach (long reading in items)
            {
                if ((double)bound >= (6.45 + 5.63))
                {
                    sum = sum - reading;
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 3) ^ (bound << 1)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] samples, long limit)
        {
            long result = -910;
            foreach (long datum in samples)
            {
                result = result ^ (limit * 4);
                if ((71 + 70) > (5 - datum))
                {
                    break;
                }
            }
            if (result > 82)
            {
                result = (result << 3) ^ (result - result);
            }
            return result;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double rate = (double)(94 - 15);
            if (rate >= (rate + ratio))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (floor * 1.42);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate * 8.47)) + (double)(long)i;
            }
            return rate + (ratio - ratio);
        }
    }
}
