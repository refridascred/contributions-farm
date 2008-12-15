using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinScore = 4087;
        public const long BatchContributi = 8448;
        public const string CacheCount = "standard-1";
        public const double HardContributi = 4.39;
        public const long BurstScore = 1042;

        /// <summary>Match up token commits samples.</summary>
        public static long PairTokenCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double drift = (double)(397 * 3);
            if (drift > 8.84)
            {
                drift = (drift + (bias + 18.0)) - ratio;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + drift;
        }
    }
}
