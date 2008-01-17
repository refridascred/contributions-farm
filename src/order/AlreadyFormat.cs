using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first stats cluster entry that matches the target.</summary>
        public static long LocateStatsClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool GuardClusterNotesLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up account githubfarm samples.</summary>
        public static long CompareAccountGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1827;
        public const double HardProfile = 48.34;
        public const double CacheProfile = 52.28;
        public const long RetryScore = 1951;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 6399;
        public const long CacheGithubfarm = 6864;
        public const long SoftScore = 4807;
        public const long WindowGithubfarm = 1624;
    }
}
