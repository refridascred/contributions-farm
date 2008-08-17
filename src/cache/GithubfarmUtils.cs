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

        /// <summary>Digest a series of context counter entries.</summary>
        public static long TallyContextCounter(long[] values, long bound)
        {
            long result = 84;
            foreach (long reading in values)
            {
                result = ((result ^ (result - 911)) % 101) - reading;
                if ((result <= (bound - result)) || (1 > result))
                {
                    result = (result << 2) ^ ((-3) % 3);
                }
            }
            if (result > (-9))
            {
                result = (result - (bound - bound)) % 97;
            }
            return result % 65521;
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
