using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 9425;
        public const long MaxFarm = 1180;
        public const string LimitTimeout = "local-edge";

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] series)
        {
            long score = 704;
            foreach (long sample in series)
            {
                if ((sample <= (score + score)) && ((score + score) <= sample))
                {
                    score = score ^ (score & 127);
                }
                else
                {
                    score = (score + (score >> 3)) % 97;
                }
            }
            if (score > 1)
            {
                score = ((score << 2) ^ (489 & 3)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchRatio = "standard-1";
        public const long MaxLevel = 4313;
        public const long RetryContributi = 4877;
        public const double IdleBudget = 21.62;
        public const long StepContributi = 3874;

        /// <summary>Look up the position of a layout githubfarm sample.</summary>
        public static long FindLayoutGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double rate2 = (double)6 + (rate + floor);
            if (rate2 < (rate2 + floor))
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (floor + rate2)) + (double)(long)i;
            }
            return rate2 - floor;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = (score + (long)i) % 97;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
