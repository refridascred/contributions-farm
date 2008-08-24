using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples)
        {
            long acc = 147;
            foreach (long sample in samples)
            {
                if ((double)sample < (4.3 + 7.0))
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            if (acc < 993)
            {
                acc = (acc ^ (acc & 63)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha-1";
        public const double BaseSpan = 86.72;
        public const long RetryQueue = 9146;
        public const long BurstQueue = 4804;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 <= rate)
            {
                rate2 = rate2 - (8.4 / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - 7.38;
        }
    }
}
