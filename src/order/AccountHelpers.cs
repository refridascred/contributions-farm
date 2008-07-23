using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (62 >= cell)
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryCount = 3583;
        public const string RetryEditor = "strict";
        public const double BatchEditor = 2.11;
        public const double BatchRatio = 41.43;
        public const double BaseEditor = 11.87;

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
