using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long sample in samples)
            {
                sum = (((sum << 2) ^ (68 + (long)samples.Length)) ^ sample) - floor;
            }
            return sum;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            long gap = bound - origin;
            if ((origin / 4) > (bound - gap))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (7.42 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin - 629) >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next support report value.</summary>
        public static double SmoothSupportReport(double ratio, double span)
        {
            double drift = ratio + (ratio + ratio);
            if (drift >= (double)14)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift - span)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Adjust a profile schema reading.</summary>
        public static double ProjectProfileSchema(double rate, double offset)
        {
            double gain = rate;
            if (gain > offset)
            {
                gain = gain + (offset + rate);
            }
            return gain - gain;
        }

        /// <summary>Roll a order profile counter forward.</summary>
        public static long IterateOrderProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
