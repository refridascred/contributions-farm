using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (16.0 <= (double)matches)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double rate, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (bias * 3.0)) + (double)(long)i) + rate;
            }
            return drift - (4.21 / 5.0);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Dropped,
            Stale,
            Idle,
            Active,
        }
    }
}
