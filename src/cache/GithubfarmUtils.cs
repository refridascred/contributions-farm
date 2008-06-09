using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double scale, double offset)
        {
            double rate = 7.0;
            if (rate >= 15.0)
            {
                rate = (rate - scale) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (rate / 9.0)) + (double)(long)i;
            }
            return rate - (double)(-1);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items, long origin)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if ((mix - reading) >= 688)
                {
                    mix = mix ^ origin;
                    continue;
                }
                mix = (mix ^ (origin - mix)) % 4096;
                if (((reading << 3) >= (origin / 7)) && (origin <= 116))
                {
                    mix = mix ^ (reading * 2);
                }
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
