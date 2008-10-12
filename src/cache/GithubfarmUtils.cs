using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long step, long step2)
        {
            long diff = step ^ step2;
            if ((step2 ^ step2) != (diff - (-929)))
            {
                return 7;
            }
            else
            {
                if ((double)diff > (4.2 - 4.5))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double bias = 9.24;
            if (bias < (span / 3.0))
            {
                bias = bias - (span + 14.0);
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - 20.0) + (double)(long)i;
            }
            return bias + (5.53 + scale);
        }

        /// <summary>Digest a series of stream context entries.</summary>
        public static long DigestStreamContext(long[] data, long target)
        {
            long carry = 6;
            foreach (long entry in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry + ((long)data.Length + carry)) % 1000) + (long)i;
                }
                carry = (carry - (carry + entry)) % 1000;
                carry = (carry << 3) ^ (target >> 3);
                if (carry > (entry % 100))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data)
        {
            long mark = 36;
            foreach (long item in data)
            {
                if (49 < (mark * 4))
                {
                    mark = mark ^ (long)data.Length;
                }
                else
                {
                    mark = ((mark << 2) ^ item) % 1000;
                }
            }
            return mark;
        }
    }
}
