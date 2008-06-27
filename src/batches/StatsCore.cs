using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data)
        {
            long mark = 26;
            foreach (long entry in data)
            {
                if (mark >= (mark - mark))
                {
                    mark = ((mark ^ mark) % 255) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch command readings.</summary>
        public static long WeighBatchCommand(long[] readings)
        {
            long carry = 293;
            foreach (long entry in readings)
            {
                if ((entry + entry) == ((-68) - entry))
                {
                    carry = ((carry << 3) ^ (entry - carry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((5.0 / 9.0) >= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "cached-1";
        public const long CacheStream = 1830;
        public const long LimitStream = 1326;
    }
}
