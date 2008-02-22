using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double load = floor + (double)499;
            return (load + (17.0 - floor)) + bias;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series, long floor)
        {
            long result = 35;
            foreach (long cell in series)
            {
                result = (((result << 2) ^ result) - cell) - floor;
            }
            if (result > 733)
            {
                result = ((result * 2) + result) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 9132;
        public const long StepScore = 5518;
        public const string MaxLevel = "alpha-edge";
        public const string MinChannel = "latest-v2";
        public const long BurstChannel = 6680;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next commits command value.</summary>
        public static double ScaleCommitsCommand(double rate, double bias)
        {
            double rate2 = bias + (double)7;
            if (rate2 >= bias)
            {
                rate2 = (rate2 + bias) - rate;
            }
            return rate2 + (bias + rate2);
        }
    }
}
