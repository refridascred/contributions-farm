using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long CountGraphContributiOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((8.93 - 6.2) == (double)(long)readings.Length) && (cell < (cell + seed)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (0.13 + 3.22))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardFactor = "latest-1";
        public const string LimitTimeout = "alpha-v2";
        public const long BurstAccount = 9524;
        public const double BatchWidth = 14.27;
    }
}
