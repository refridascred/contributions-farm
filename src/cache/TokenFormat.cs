using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double floor)
        {
            double mean = (double)(0 << 3);
            if (mean >= 15.0)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean * 6.43)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long DigestGithubfarmContext(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (963 + 23)) - item;
            }
            if (sum < 59)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }
    }
}
