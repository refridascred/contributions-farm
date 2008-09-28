using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 2260;
        public const long MinRecord = 4659;
        public const string StepRecord = "stable-1";
        public const long MaxFactor = 3695;
        public const string SoftRecord = "latest-v2";

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Pending,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] levels)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                mark = (mark * 2) + (item >> 2);
                mark = (mark + (item >> 4)) % 97;
            }
            return mark % 65521;
        }
    }
}
