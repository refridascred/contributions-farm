using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double bias, double offset)
        {
            double mean = (offset / 9.0) + offset;
            if (mean <= (1.9 * 7.4))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (bias + mean);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "strict-edge";
        public const long DefaultAccount = 5051;
        public const string LimitTimeout = "local-1";
        public const long LimitAccount = 8153;
    }
}
