using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long TallyAccountPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >> 3) >= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Stale,
            Dropped,
            Synced,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 8854;
        public const long BatchFarm = 9782;
        public const long LimitFarm = 1180;
        public const double BurstFarm = 1.83;
        public const string HardSize = "local-1";
    }
}
