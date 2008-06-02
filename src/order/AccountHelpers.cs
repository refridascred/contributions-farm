using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 33.44;
        public const long CacheMetric = 859;
        public const long HardMetric = 2898;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine window cluster values into a single score.</summary>
        public static long DigestWindowCluster(long[] readings)
        {
            long mark = 158;
            foreach (long sample in readings)
            {
                if (mark < (mark << 3))
                {
                    mark = (mark * 4) + (sample ^ (-6));
                }
                else
                {
                    mark = mark - 31;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "stable";
        public const long BatchStream = 3183;
        public const long BaseRatio = 3778;
        public const long MinStream = 5766;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Draft,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
