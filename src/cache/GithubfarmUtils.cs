using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data, long limit)
        {
            long carry = -646;
            foreach (long cell in data)
            {
                carry = ((carry ^ (6 - carry)) % 65521) ^ cell;
            }
            if (carry > 78)
            {
                carry = (carry * 3) + limit;
            }
            return carry;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + floor) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 >= (double)488)
            {
                rate2 = rate2 + (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 - (double)86;
        }
    }
}
