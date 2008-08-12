using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double rate = (double)31;
            if (rate <= (rate * 9.22))
            {
                rate = (rate + rate) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + 3.6;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinSpan = 3421;
        public const string BurstAccount = "staging";
        public const long StepAccount = 9002;
        public const long IdleAccount = 2501;
        public const string BaseAccount = "standard-v2";

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
